namespace Server.Pages.Cms.Pages
{
	public class DetailsModel : Infrastructure.BasePageModel
	{
		public DetailsModel() : base()
		{
		}

		public void OnGet(string name)
		{
		}

		//public async System.Threading.Tasks.Task
		//	<Microsoft.AspNetCore.Mvc.IActionResult> OnGetAsync(int? id)
		//{
		//	if (id == null)
		//	{
		//		return NotFound();
		//	}

		//	//Course = await _context.Courses
		//	//	.AsNoTracking()
		//	//	.Include(c => c.Department)
		//	//	.FirstOrDefaultAsync(m => m.CourseID == id);

		//	//if (Course == null)
		//	//{
		//	//	return NotFound();
		//	//}

		//	return Page();
		//}
	}
}
