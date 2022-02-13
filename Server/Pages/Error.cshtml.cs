namespace Server.Pages
{
	[Microsoft.AspNetCore.Mvc.IgnoreAntiforgeryToken]
	[Microsoft.AspNetCore.Mvc.ResponseCache
		(Duration = 0, Location = Microsoft.AspNetCore.Mvc.ResponseCacheLocation.None, NoStore = true)]
	public class ErrorModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public ErrorModel() : base()
		{
		}

		public string? RequestId { get; set; }

		public bool ShowRequestId
		{
			get
			{
				var result =
					!string.IsNullOrEmpty(RequestId);

				return result;
			}
		}

		public string? ExceptionMessage { get; set; }

		public void OnGet()
		{
			RequestId =
				System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier;

			var exceptionHandlerPathFeature = HttpContext.Features.Get
				<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerPathFeature>();

			if (exceptionHandlerPathFeature?.Error is System.IO.FileNotFoundException)
			{
				ExceptionMessage =
					$"The file was not found.";
			}

			if (exceptionHandlerPathFeature?.Path == "/")
			{
				ExceptionMessage ??= string.Empty;
				ExceptionMessage += " Page: Home.";
			}
		}
	}
}
