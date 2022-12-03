using CanteenManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CanteenManagement.Controllers
{
    public class CategoryController : Controller
    {
        CanteenContext CanteenContext = new CanteenContext();
        public ActionResult CategoryList()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllSouthIndianfood()
        {
            try
            {
                List<SouthIndian> southIndianfood = CanteenContext.southIndian.ToList();
                return View(southIndianfood);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult AddSouthFood()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSouthFood(SouthIndian fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.southIndian.Add(fooditem);
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllSouthIndianfood");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult EditSouthFood(int id)
        {
            try
            {
                SouthIndian fooditem = CanteenContext.southIndian.Find(id);
                return View(fooditem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSouthFood(SouthIndian fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.Entry<SouthIndian>(fooditem).State = System.Data.Entity.EntityState.Modified;
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllSouthIndianfood");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult DeleteSouthFood(int id)
        {
            try
            {
                SouthIndian fooditem = CanteenContext.southIndian.Find(id);
                CanteenContext.southIndian.Remove(fooditem);
                CanteenContext.SaveChanges();
                return RedirectToAction("GetAllSouthIndianfood");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult GetAllNorthIndianfood()
        {
            try
            {
                List<NorthIndian> northindianfood = CanteenContext.northIndian.ToList();
                return View(northindianfood);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult AddNorthfood()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNorthfood(NorthIndian fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.northIndian.Add(fooditem);
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllNorthIndianfood");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult EditNorthfood(int id)
        {
            try
            {
                var fooditem = CanteenContext.northIndian.Find(id);
                return View(fooditem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditNorthfood(NorthIndian fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.Entry<NorthIndian>(fooditem).State = System.Data.Entity.EntityState.Modified;
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllNorthIndianfood");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult DeleteNorthfood(int id)
        {
            try
            {
                NorthIndian fooditem = CanteenContext.northIndian.Find(id);
                CanteenContext.northIndian.Remove(fooditem);
                CanteenContext.SaveChanges();
                return RedirectToAction("GetAllNorthIndianfood");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult GetAllChinese()
        {
            try
            {
                List<Chinese> Chinesefood = CanteenContext.chinese.ToList();
                return View(Chinesefood);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult AddChinese()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddChinese(Chinese fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.chinese.Add(fooditem);
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllChinese");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult EditChinese(int id)
        {
            try
            {
                var fooditem = CanteenContext.chinese.Find(id);
                return View(fooditem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditChinese(Chinese fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.Entry<Chinese>(fooditem).State = System.Data.Entity.EntityState.Modified;
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllChinese");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult DeleteChinese(int id)
        {
            try
            {
                Chinese fooditem = CanteenContext.chinese.Find(id);
                CanteenContext.chinese.Remove(fooditem);
                CanteenContext.SaveChanges();
                return RedirectToAction("GetAllChinese");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]

        public ActionResult GetAllDeserts()
        {
            try
            {
                List<Deserts> Desertsfood = CanteenContext.deserts.ToList();
                return View(Desertsfood);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult AddDeserts()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDeserts(Deserts fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.deserts.Add(fooditem);
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllDeserts");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult EditDeserts(int id)
        {
            try
            {
                var fooditem = CanteenContext.deserts.Find(id);
                return View(fooditem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDeserts(Deserts fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.Entry<Deserts>(fooditem).State = System.Data.Entity.EntityState.Modified;
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllDeserts");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult DeleteDeserts(int id)
        {
            try
            {
                Deserts fooditem = CanteenContext.deserts.Find(id);
                CanteenContext.deserts.Remove(fooditem);
                CanteenContext.SaveChanges();
                return RedirectToAction("GetAllDeserts");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]

        public ActionResult GetAllBeverages()
        {
            try
            {
                List<Beverages> Beveragesfood = CanteenContext.beverages.ToList();
                return View(Beveragesfood);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult AddBeverages()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBeverages(Beverages fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.beverages.Add(fooditem);
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllBeverages");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult EditBeverages(int id)
        {
            try
            {
                var fooditem = CanteenContext.beverages.Find(id);
                return View(fooditem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditBeverages(Beverages fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.Entry<Beverages>(fooditem).State = System.Data.Entity.EntityState.Modified;
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllBeverages");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult DeleteBeverages(int id)
        {
            try
            {
                Beverages fooditem = CanteenContext.beverages.Find(id);
                CanteenContext.beverages.Remove(fooditem);
                CanteenContext.SaveChanges();
                return RedirectToAction("GetAllBeverages");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
    
