using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementOrder.Data;
using RestaurantManagementOrder.Models;
using RestaurantManagementOrder.Models.Users;
using RestaurantManagementOrder.Services;

namespace RestaurantManagementOrder.Controllers
{
    [Authorize(Policy = "Admin")]
    public class UsersController : Controller
    {
        private readonly RestaurantManagementOrderContext _context;
        private readonly AuthService _authService;

        public UsersController(RestaurantManagementOrderContext context, AuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        public async Task<IActionResult> Index()
        {
            var all = new List<IUser>();
            all.AddRange(await _context.Admin.ToListAsync());
            all.AddRange(await _context.Cook.ToListAsync());
            all.AddRange(await _context.Waiter.ToListAsync());
            return View(all);
        }

        public async Task<IActionResult> Details([Bind(Prefix = "id")] string idStr)
        {
            if (idStr == null)
            {
                return NotFound();
            }

            var user = await GetUserFromCompoundId(idStr);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Admins/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Type,Name,Email,Password")] GeneralUser user)
        {
            if (ModelState.IsValid)
            {
                string password = _authService.PasswordHash(user.Password);
                switch (user.Type)
                {
                    case UserType.Admin:
                        _context.Add(new Admin()
                        {
                            Email = user.Email,
                            Password = password,
                            Name = user.Name
                        }); break;
                    case UserType.Cook:
                        _context.Add(new Cook()
                        {
                            Email = user.Email,
                            Password = password,
                            Name = user.Name
                        }); break;
                    case UserType.Waiter:
                        _context.Add(new Waiter()
                        {
                            Email = user.Email,
                            Password = password,
                            Name = user.Name
                        }); break;
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public async Task<IActionResult> Edit([Bind(Prefix = "id")] string idStr)
        {
            if (idStr == null)
            {
                return NotFound();
            }

            var user = await GetUserFromCompoundId(idStr);
            if (user == null)
            {
                return NotFound();
            }
            var genUser = new GeneralUser()
            {
                Email = user.Email,
                Type = user.Type,
                Name = user.Name,
                UserCompoundId = idStr
            };
            return View(genUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("UserCompoundId,Name,Email,Password")] GeneralUser genUser)
        {

            if (ModelState.IsValid)
            {
                var user = await GetUserFromCompoundId(genUser.UserCompoundId);
                var userId = Convert.ToInt32(genUser.UserCompoundId.Split('-')[1]);
                var password = user.Password;
                if (!string.IsNullOrEmpty(genUser.Password))
                {
                    password = _authService.PasswordHash(genUser.Password);
                }
                user.Email = genUser.Email;
                user.Name = genUser.Name;
                user.Password = password;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { id = genUser.UserCompoundId });
            }
            return View(genUser);
        }

        public async Task<IActionResult> Delete([Bind(Prefix = "id")] string idStr)
        {
            if (idStr == null)
            {
                return NotFound();
            }

            var user = await GetUserFromCompoundId(idStr);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([Bind(Prefix = "id")] string idStr)
        {
            var user = await GetUserFromCompoundId(idStr);
            _context.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<IUser> GetUserFromCompoundId(string idStr)
        {
            var parts = idStr.Split("-");
            var type = parts[0];
            var id = Convert.ToInt32(parts[1]);
            IUser user = null;
            if (type == "Admin")
                user = await _context.Admin
                    .FirstOrDefaultAsync(m => m.AdminId == id);
            else if (type == "Waiter")
                user = await _context.Waiter
                    .FirstOrDefaultAsync(m => m.WaiterId == id);
            if (type == "Cook")
                user = await _context.Cook
                    .FirstOrDefaultAsync(m => m.CookId == id);
            return user;
        }
    }
}
