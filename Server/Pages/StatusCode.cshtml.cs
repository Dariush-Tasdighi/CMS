namespace Server.Pages
{
	[Microsoft.AspNetCore.Mvc.ResponseCache
		(Duration = 0, Location = Microsoft.AspNetCore.Mvc.ResponseCacheLocation.None, NoStore = true)]
	public class StatusCodeModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public StatusCodeModel() : base()
		{
		}
		public int OriginalStatusCode { get; set; }

		public string? OriginalPathAndQuery { get; set; }

		public void OnGet(int statusCode)
		{
			OriginalStatusCode = statusCode;

			var statusCodeReExecuteFeature = HttpContext.Features.Get
				<Microsoft.AspNetCore.Diagnostics.IStatusCodeReExecuteFeature>();

			if (statusCodeReExecuteFeature is not null)
			{
				OriginalPathAndQuery = string.Join
					(statusCodeReExecuteFeature.OriginalPathBase,
					statusCodeReExecuteFeature.OriginalPath,
					statusCodeReExecuteFeature.OriginalQueryString);
			}
		}
	}
}
