using System;
using System.Linq;
using System.Collections.Generic;
	
namespace course.Models
{   
	public  class ComapnyRepository : EFRepository<Comapny>, IComapnyRepository
	{

	}

	public  interface IComapnyRepository : IRepository<Comapny>
	{

	}
}