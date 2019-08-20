namespace course.Models
{
	public static class RepositoryHelper
	{
		public static IUnitOfWork GetUnitOfWork()
		{
			return new EFUnitOfWork();
		}		
		
		public static CompanyRepository GetCompanyRepository()
		{
			var repository = new CompanyRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static CompanyRepository GetCompanyRepository(IUnitOfWork unitOfWork)
		{
			var repository = new CompanyRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		

		public static ProductRepository GetProductRepository()
		{
			var repository = new ProductRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static ProductRepository GetProductRepository(IUnitOfWork unitOfWork)
		{
			var repository = new ProductRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		
	}
}