namespace Models.SeedWork
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static System.DateTime Now
		{
			get
			{
				//var result =
				//	System.DateTime.UtcNow;

				var result =
					System.DateTime.Now;

				return result;
			}
		}
	}
}
