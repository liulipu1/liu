using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;
using Webdiyer.WebControls.Mvc;
namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        deptBLL dbll = new deptBLL();
        empBLL bll = new empBLL();
        /// <summary>
        /// 部门显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int pageIndex=1,int pageSize=2)
        {
            PagedList<dept> aa = dbll.LoadEntity(c => true).OrderBy(t => t.DId).ToPagedList(pageIndex,pageSize);
            ViewBag.num = bll.SUnm();
            return View(aa);
        }

        /// <summary>
        /// 员工显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            var ss = bll.LoadEntity(c =>c.DId==id).ToList();
            return View(ss);
        }
         /// <summary>
         /// 部门修改
         /// </summary>
         /// <param name="id"></param>
         /// <returns></returns>
        public ActionResult Edit(int id)
        {
            var aa = dbll.LoadEntity(c => c.DId == id).FirstOrDefault();
            return View(aa);
        }
        [HttpPost]
        public ActionResult Edit(dept info)
        {
            info = dbll.Entity(info);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 员工修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Editss(int id)
        {
            var aa = bll.LoadEntity(c => c.EId == id).FirstOrDefault();
            return View(aa);
        }
        [HttpPost]
        public ActionResult Editss(emp info)
        {
            info = bll.Entity(info);
            return RedirectToAction("Details");
        }
        public ActionResult Delete(int id)
        {
            var data = bll.LoadEntity(c => c.DId == id).ToList();
            var deptdate = dbll.LoadEntity(c => c.DId == id).FirstOrDefault();
            if (data.Count()!=0)
            {
                return Content("<script>alert('部门有员工，此部门不能删除');location.href='/Home/Index'</script>");
            }
            else
            {
                dbll.Delte(deptdate);
                return Content("<script>alert('删除成功');location.href='/Home/Index'</script>");
            }

            return View();
        }
    }
}
