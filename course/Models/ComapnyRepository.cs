using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;

namespace course.Models
{   
	public  class ComapnyRepository : EFRepository<Comapny>, IComapnyRepository
	{
        public IQueryable<Comapny> GetAll(int DataSN = 0)
        {
            IQueryable<Comapny> Result = base.All();

            return Result.OrderBy(o => o.SN);
        }

        public Comapny Find(int? SN)
        {
            return GetAll().Where(o => o.SN == SN).SingleOrDefault();
        }

        public Comapny FindByIndexSN(int SN, int IndexSN)
        {
            return GetAll(IndexSN).Where(o => o.SN == SN).SingleOrDefault();
        }


        public override void Delete(Comapny entity)
        {
            UnitOfWork.Context.Entry(entity).State = EntityState.Deleted;
            UnitOfWork.Commit();
        }
        public void Update(Comapny entity)
        {
            UnitOfWork.Context.Entry(entity).State = EntityState.Modified;
            UnitOfWork.Commit();
        }

        public void Insert(Comapny entity)
        {
            Add(entity);
            UnitOfWork.Commit();
        }
    }

	public  interface IComapnyRepository : IRepository<Comapny>
	{

	}
}