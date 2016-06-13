using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class empBLL
    {
        empDAL dal = new empDAL();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public emp Add(emp info)
        {
            return dal.Add(info);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public emp Entity(emp info)
        {
            return dal.Entity(info);
        }
        /// <summary>
        ///删除
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Delte(emp info)
        {
            return dal.Delte(info);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="whereDBamde"></param>
        /// <returns></returns>
        public IQueryable<emp> LoadEntity(System.Linq.Expressions.Expression<Func<emp, bool>> whereDBamde)
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
