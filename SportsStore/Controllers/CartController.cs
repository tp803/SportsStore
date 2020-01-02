using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SportsStore.Infrastructure;
using SportsStore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsStore.Controllers
{
    /*public class CartController : Controller
    {
        private IProductRepository repository;

        public CartController(IProductRepository repo)
        {
            repository = repo;
        }

        public RedirectToActionResult AddToCart(int productID, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productID);

            if(product != null)
            {
                Cart cart = GetCart();
                cart.AddItem(product, 1);
                saveCart(cart);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {

        }
    }*/
}
