using CoffeeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TESTING.Models;
using System.Data.Entity;
using CoffeeProject.Models.Cheese_Burger_Menu;
using System.IO;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;

namespace CoffeeProject.Controllers
{
    public class UserController : Controller
    {
        private _CONTEXT _CONTEXT=new _CONTEXT();

        public UserController()
        {
            _CONTEXT = new _CONTEXT(); // Initialize your context here
        }

        public ActionResult cheeseBurgerList()
        {
            var Randomviews = new RandomCheeseBurger()
            {
                ADpages = new AddressPages(),
                ADpageslist = _CONTEXT.NameAddressPages.ToList(),
                categorylist = _CONTEXT.CategoryList.ToList(),
                orderlist = _CONTEXT.MenuList.ToList(),
                sizelist=_CONTEXT.SizeList.ToList()
            };
            _CONTEXT.SaveChanges();
            return View("~/Views/User/cheeseBurgerList.cshtml", Randomviews);
        }

        [HttpGet]
        public ActionResult CreateList()//we must hide the id
        {
            var Randomviews = new RandomCheeseBurger()
            {
                ADpages = new AddressPages(),
                categorylist = _CONTEXT.CategoryList.ToList(),
                orderlist = new List<OrderNames>(),//we put new because it has relation with categorylist by changing the values of it
                sizelist = new List<Size>()
            };
         

            return View("~/Views/User/CreateList.cshtml", Randomviews);
        }
      
        [HttpGet]
        public JsonResult CreateCategoryValues(int categoryId, bool isarabic)//here we use ajax to can switch between the dropdownlist
        {
            List<OrderNames> menuList = new List<OrderNames>();
            List<Size>sizelist=new List<Size>();

            if (isarabic == true && categoryId == 1) // Breakfast Arabic
            {
                menuList = _CONTEXT.MenuList
                    .Where(m => m.id >= 1 && m.id <= 6).AsEnumerable()
                    .Select(m => new OrderNames { id = m.id, CheeseBurgerNames = m.CheeseBurgerNames })
                    .ToList();
                
               sizelist=_CONTEXT.SizeList.Where(e=>e.Id>=1&&e.Id<=3).AsEnumerable().Select(w=>new Size { Id=w.Id,Namesize=w.Namesize}).ToList();
            }
            else if (isarabic == true && categoryId == 2) // Lunch arabic
            {
                menuList = _CONTEXT.MenuList
                    .Where(m => m.id >= 13 && m.id <= 24).AsEnumerable()
                    .Select(m => new OrderNames { id = m.id, CheeseBurgerNames = m.CheeseBurgerNames })
                    .ToList();
                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 1 && e.Id <= 3).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();


            }
            else if (isarabic == false && categoryId == 1)//here for breakfast english
            {
                menuList = _CONTEXT.MenuList.Where(m => m.id >= 7 && m.id <= 12).AsEnumerable()
                    .Select(s => new OrderNames { id = s.id, CheeseBurgerNames = s.CheeseBurgerNames }).ToList();
                
                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 4 && e.Id <= 6).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();

            }

            else if (isarabic == false && categoryId == 2)
            {
                menuList = _CONTEXT.MenuList.Where(a => a.id >= 25 && a.id <= 36).AsEnumerable()
                    .Select(w => new OrderNames { id = w.id, CheeseBurgerNames = w.CheeseBurgerNames }).ToList();

                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 4 && e.Id <= 6).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();

            }

            else if (isarabic == true && categoryId == 3)
            {
                menuList = _CONTEXT.MenuList.Where(a => a.id >= 37 && a.id <= 39).AsEnumerable()
                    .Select(a => new OrderNames { id = a.id, CheeseBurgerNames = a.CheeseBurgerNames }).ToList();

                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 1 && e.Id <= 3).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();

            }
            else if (isarabic == false && categoryId == 3)
            {
                menuList = _CONTEXT.MenuList.Where(q => q.id >= 40 && q.id <= 42).AsEnumerable()
                    .Select(a => new OrderNames { id = a.id, CheeseBurgerNames = a.CheeseBurgerNames }).ToList();

                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 4 && e.Id <= 6).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();

            }
            return Json(new{ menuList=menuList,sizelist=sizelist}, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateList(RandomCheeseBurger random)
        {
            if (ModelState.IsValid)//we put the valid to can return to the view if the required isn
            {
                _CONTEXT.NameAddressPages.Add(random.ADpages);
                _CONTEXT.SaveChanges();
                return RedirectToAction("cheeseBurgerList");
            }

            random.categorylist = _CONTEXT.CategoryList.ToList();
            random.orderlist = _CONTEXT.MenuList.ToList();
            random.sizelist = _CONTEXT.SizeList.ToList();

            return View("~/Views/User/CreateList.cshtml", random);
        }


            [HttpGet]
        public ActionResult EditList(int id)//every get must have initilization
        {
            var AddresspagesId = _CONTEXT.NameAddressPages.Find(id);

            var random = new RandomCheeseBurger()
            {
                ADpages = AddresspagesId,
                categorylist = _CONTEXT.CategoryList.ToList(),
                orderlist = _CONTEXT.MenuList.ToList(),
                sizelist = _CONTEXT.SizeList.ToList()
            };
            _CONTEXT.SaveChanges();
            return View("~/Views/User/EditList.cshtml", random);
        }
        [HttpGet]
        public JsonResult EditCategoryValues(int categoryId, bool isarabic, List<OrderNames> menuList,List<Size>sizelist)
        {


            if (isarabic == true && categoryId == 1) // Breakfast Arabic
            {
                menuList = _CONTEXT.MenuList
                    .Where(m => m.id >= 1 && m.id <= 6).AsEnumerable()
                    .Select(m => new OrderNames { id = m.id, CheeseBurgerNames = m.CheeseBurgerNames })
                    .ToList();

                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 1 && e.Id <= 3).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();
            }
            else if (isarabic == true && categoryId == 2) // Lunch arabic
            {
                menuList = _CONTEXT.MenuList
                    .Where(m => m.id >= 13 && m.id <= 24).AsEnumerable()
                    .Select(m => new OrderNames { id = m.id, CheeseBurgerNames = m.CheeseBurgerNames })
                    .ToList();
                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 1 && e.Id <= 3).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();
            }
            else if (isarabic == false && categoryId == 1)//here for breakfast english
            {
                menuList = _CONTEXT.MenuList.Where(m => m.id >= 7 && m.id <= 12).AsEnumerable()
                    .Select(s => new OrderNames { id = s.id, CheeseBurgerNames = s.CheeseBurgerNames }).ToList();

                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 4 && e.Id <= 6).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();

            }

            else if (isarabic == false && categoryId == 2)
            {
                menuList = _CONTEXT.MenuList.Where(a => a.id >= 25 && a.id <= 36).AsEnumerable()
                    .Select(w => new OrderNames { id = w.id, CheeseBurgerNames = w.CheeseBurgerNames }).ToList();

                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 4 && e.Id <= 6).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();

            }
            else if (isarabic == true && categoryId == 3)
            {
                menuList = _CONTEXT.MenuList.Where(a => a.id >= 37 && a.id <= 39).AsEnumerable()
                    .Select(a => new OrderNames { id = a.id, CheeseBurgerNames = a.CheeseBurgerNames }).ToList();
                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 1 && e.Id <= 3).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();
            }
            else if (isarabic == false && categoryId == 3)
            {
                menuList = _CONTEXT.MenuList.Where(q => q.id >= 40 && q.id <= 42).AsEnumerable()
                    .Select(a => new OrderNames { id = a.id, CheeseBurgerNames = a.CheeseBurgerNames }).ToList();
                
                sizelist = _CONTEXT.SizeList.Where(e => e.Id >= 4 && e.Id <= 6).AsEnumerable().Select(w => new Size { Id = w.Id, Namesize = w.Namesize }).ToList();

            }
           
                return Json(new { menuList = menuList, sizelist = sizelist }, JsonRequestBehavior.AllowGet);

            //here in switch  case alternative of If

            //int minId = 0;
            //int maxId = 0;

            //switch (categoryId)
            //{
            //    case 1:
            //        minId = isarabic ? 1 : 7;   
            //        maxId = isarabic ? 6 : 12;
            //        break;
            //    case 2:
            //        minId = isarabic ? 13 : 25;
            //        maxId = isarabic ? 24 : 36;
            //        break;
            //    case 3:
            //        minId = isarabic ? 37 : 40;
            //        maxId = isarabic ? 39 : 42;
            //        break;
            //}

            //var menuList = _CONTEXT.MenuList
            //    .Where(m => m.id >= minId && m.id <= maxId).AsEnumerable()
            //    .Select(m => new OrderNames { id = m.id, CheeseBurgerNames = m.CheeseBurgerNames })
            //    .ToList();

            //return Json(menuList, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult EditList(int id, RandomCheeseBurger randomaddresslist)
        {

            var addressIdValue = _CONTEXT.NameAddressPages.Single(m => m.Id == id);
            addressIdValue.price = randomaddresslist.ADpages.price;
            addressIdValue.CategoryId = randomaddresslist.ADpages.CategoryId;
            addressIdValue.OrderId = randomaddresslist.ADpages.OrderId;
            addressIdValue.sizeId = randomaddresslist.ADpages.sizeId;
            _CONTEXT.SaveChanges();
            return RedirectToAction("cheeseBurgerList", "User", randomaddresslist);
        }

        public ActionResult DeleteBreakFast(int id)
        {
            var addressId = _CONTEXT.NameAddressPages.Find(id);
            _CONTEXT.NameAddressPages.Remove(addressId);
            _CONTEXT.SaveChanges();
            return RedirectToAction("cheeseBurgerList");
        }



        //this create with ajax and DataTable

        public ActionResult cheeseBurgerAjax()
        {
            var randomViews = new RandomCheeseBurger()
            {
                ADpageslist = _CONTEXT.NameAddressPages.ToList()
                
            };

            return View("~/Views/User/cheeseBurgerAjax.cshtml", randomViews);
        }
        [HttpGet]
        public JsonResult CategoryAjaxValues()
        {
            var data = _CONTEXT.NameAddressPages
                .Include(item => item.categoryOrder)//here the dropdownlists
                .Include(item => item.menuNames)//here the dropdownlists
                .Select(item => new
                {
                    id = item.Id,
                    price = item.price,
                    categoryName = item.categoryOrder != null ? item.categoryOrder.CategoryName : "N/A",
                    cheeseBurgerName = item.menuNames != null ? item.menuNames.CheeseBurgerNames : "N/A"
                })
                .ToList();

            return Json(new { data = data }, JsonRequestBehavior.AllowGet);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _CONTEXT.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}