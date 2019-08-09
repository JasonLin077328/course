namespace course.Models
{
	public static class RepositoryHelper
	{
		public static IUnitOfWork GetUnitOfWork()
		{
			return new EFUnitOfWork();
		}		
		
		public static ComapnyRepository GetComapnyRepository()
		{
			var repository = new ComapnyRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static ComapnyRepository GetComapnyRepository(IUnitOfWork unitOfWork)
		{
			var repository = new ComapnyRepository();
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