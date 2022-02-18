namespace Models.Cms
{
	public class Page : SeedWork.Entity
	{
		public Page() : base()
		{
		}

		public string? Title { get; set; }

		public string? Body { get; set; }
	}
}
