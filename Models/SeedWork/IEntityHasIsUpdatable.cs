namespace Models.SeedWork
{
	public interface IEntityHasIsUpdatable : IEntityHasUpdateDateTime
	{
		bool IsUpdatable { get; set; }
	}
}
