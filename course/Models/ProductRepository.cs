using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;

namespace course.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{
        public IQueryable<Product> GetAll(int CompanySN = 0)
        {
            IQueryable<Product> Result = base.All().Where(o=>o.CompanySN == CompanySN);

            return Result.OrderBy(o => o.SN);
        }

        public Product Find(int? SN)
        {
            return GetAll().Where(o => o.SN == SN).SingleOrDefault();
        }

        public Product FindByIndexSN(int SN, int IndexSN)
        {
            return GetAll(IndexSN).Where(o => o.SN == SN).SingleOrDefault();
        }


        public override void Delete(Product entity)
        {
            UnitOfWork.Context.Entry(entity).State = EntityState.Deleted;
            UnitOfWork.Commit();
        }
        public void Update(Product entity)
        {
            UnitOfWork.Context.Entry(entity).State = EntityState.Modified;
            UnitOfWork.Commit();
        }

        public void Insert(Product entity)
        {
            Add(entity);
            UnitOfWork.Commit();
        }
    }

	public  interface IProductRepository : IRepository<Product>
	{

	}
}