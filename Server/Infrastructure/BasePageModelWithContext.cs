namespace Infrastructure
{
	public abstract class BasePageModelWithContext : BasePageModel
	{
		public BasePageModelWithContext
			(Persistence.DatabaseContext context) : base()
		{
			Context = context;
		}

		public Persistence.DatabaseContext Context { get; }
	}
}
