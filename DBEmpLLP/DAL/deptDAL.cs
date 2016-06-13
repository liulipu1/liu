using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class deptDAL
    {
        Model1Container db = new Model1Container();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public dept Add(dept info)
        {
            try
            {
                db.dept.Add(info);
                db.SaveChanges();
                return info;
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public dept Entity(dept info)
        {
            try
            {
                db.Entry(info).State = System.Data.EntityState.Modified;
                db.SaveChanges();
                return info;
            }
            catch (Exception ex)
            {
                
                throw;
            }
          
        }
        /// <summary>
        ///删除
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Delte(dept info)
        {
            try
            {
                db.Entry(info).State = System.Data.EntityState.Deleted;
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                
                throw;
            }
           
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="whereDBamde"></param>
        /// <returns></returns>
        public IQueryable<dept> LoadEntity(System.Linq.Expressions.Expression<Func<dept,bool>>whereDBamde)
        {
            try
            {
                return db.dept.Where(whereDBamde);
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
        }
        /// <summary>
        /// 数量
        /// </summary>
        /// <returns></returns>
        public int SUnm()
        {
            try
            {
                return db.dept.Count();
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
        }
    }
}
