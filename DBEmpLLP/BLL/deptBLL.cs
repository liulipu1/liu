using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class deptBLL
    {
        deptDAL dal = new deptDAL();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public dept Add(dept info)
        {
            return dal.Add(info);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public dept Entity(dept info)
        {
            return dal.Entity(info);
        }
        /// <summary>
        ///删除
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Delte(dept info)
        {
            return dal.Delte(info);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="whereDBamde"></param>
        /// <returns></returns>
        public IQueryable<dept> LoadEntity(System.Linq.Expressions.Expression<Func<dept, bool>> whereDBamde)
        {
            return dal.LoadEntity(whereDBamde);
        }
        /// <summary>
        /// 数量
        /// </summary>
        /// <returns></returns>
        public int SUnm()
        {
            return dal.SUnm();
        }
    }
}
