using Microsoft.EntityFrameworkCore;

namespace Server.Pages.Cms.Pages
{
	public class IndexModel : Infrastructure.BasePageModelWithContext
	{
		public IndexModel(Persistence.DatabaseContext context) : base(context: context)
		{
		}

		//public void OnGet()
		//{
		//}

		//public void OnGet(int? id)
		//{
		//}

		[Microsoft.AspNetCore.Mvc.BindProperty]
		public System.Collections.Generic.IEnumerable<Domain.Cms.Page>? Pages { get; set; }

		public async System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.IActionResult> OnGetAsync()
		{
			Pages =
				await Context.Pages
				// AsNoTracking() -> using Microsoft.EntityFrameworkCore;
				//.AsNoTracking()
				.ToListAsync()
				;

			return Page();
		}
	}
}
