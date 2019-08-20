using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace course.Models
{   
	public  class CompanyRepository : EFRepository<Company>, ICompanyRepository
	{
        public IQueryable<Company> GetAll()
        {
            IQueryable<Company> Result = base.All();

            return Result.OrderBy(o => o.SN);
        }

        public IQueryable<Company> GetAll(string Name = "" , string Phone = "", string Address = "")
        {
            IQueryable<Company> Result = base.All();
            if (!string.IsNullOrEmpty(Name))
            {
                Result = Result.Where(o=>o.Name.Contains(Name));
            }
            if (!string.IsNullOrEmpty(Phone))
            {
                Result = Result.Where(o => o.Name.Contains(Phone));
            }
            if (!string.IsNullOrEmpty(Address))
            {
                Result = Result.Where(o => o.Name.Contains(Address));
            }
            return Result.OrderBy(o => o.SN);
        }

        public Company Find(int? SN)
        {
            return GetAll().Where(o => o.SN == SN).SingleOrDefault();
        }


        public override void Delete(Company entity)
        {
            UnitOfWork.Context.Entry(entity).State = EntityState.Deleted;
            UnitOfWork.Commit();
        }
        public void Update(Company entity)
        {
            UnitOfWork.Context.Entry(entity).State = EntityState.Modified;
            UnitOfWork.Commit();
        }

        public void Insert(Company entity)
        {
            Add(entity);
            UnitOfWork.Commit();
        }
    }

	public  interface ICompanyRepository : IRepository<Company>
	{

	}
}