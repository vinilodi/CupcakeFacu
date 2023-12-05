using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cupcakecom.Data;
using Cupcakecom.Models;
using Cupcakecom.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Cupcakecom.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public OrderController(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        //GET Checkout actioin method

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(_db.Orders.Where(e => e.ApplicationUserId == Guid.Parse(_userManager.GetUserId(User))).ToList());
        }

        //POST Checkout action method

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Checkout(Order anOrder)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                foreach (var product in products)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.PorductId = product.Id;
                    anOrder.OrderDetails.Add(orderDetails);
                }
            }

            anOrder.OrderNo = GetOrderNo();
            anOrder.ApplicationUserId = Guid.Parse(_userManager.GetUserId(User));
            _db.Orders.Add(anOrder);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<Products>());
            return View();
        }


        public string GetOrderNo()
        {
            int rowCount = _db.Orders.ToList().Count() + 1;
            return rowCount.ToString("000");
        }
    }
}
