namespace Models.SeedWork
{
	public interface IEntityHasUpdateDateTime
	{
		System.DateTime UpdateDateTime { get; }

		void SetUpdateDateTime();
	}
}
