using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class empDAL
    {
        Model1Container db = new Model1Container();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public emp Add(emp info)
        {
            db.emp.Add(info);
            db.SaveChanges();
            return info;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public emp Entity(emp info)
        {
            db.Entry(info).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return info;
        }
        /// <summary>
        ///删除
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Delte(emp info)
        {
            db.Entry(info).State = System.Data.EntityState.Deleted;
            return db.SaveChanges();
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="whereDBamde"></param>
        /// <returns></returns>
        public IQueryable<emp> LoadEntity(System.Linq.Expressions.Expression<Func<emp, bool>> whereDBamde)
        {
            return db.emp.Where(whereDBamde);
        }
        /// <summary>
        /// 数量
        /// </summary>
        /// <returns></returns>
        public int SUnm()
        {
            return db.emp.Count();
        }
    }
}
