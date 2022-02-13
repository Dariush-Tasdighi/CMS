using System.Linq;

namespace Infrastructure
{
	public class CustomCultureRouteModelConvention :
		Microsoft.AspNetCore.Mvc.ApplicationModels.IPageRouteModelConvention
	{
		public CustomCultureRouteModelConvention() : base()
		{
		}

		public void Apply
			(Microsoft.AspNetCore.Mvc.ApplicationModels.PageRouteModel model)
		{
			var selectorModels =
				new System.Collections.Generic.List
				<Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel>();

			var selectors =
				model.Selectors
				.ToList()
				;

			foreach (var selector in selectors)
			{
				var template =
					selector?.AttributeRouteModel?.Template;

				var attributeRouteModel =
					new Microsoft.AspNetCore.Mvc.ApplicationModels.AttributeRouteModel
					{
						Template =
							$"/{{culture}}/{template}",
					};

				var selectorModel =
					new Microsoft.AspNetCore.Mvc.ApplicationModels.SelectorModel()
					{
						AttributeRouteModel = attributeRouteModel,
					};


				selectorModels.Add(selectorModel);
			}

			foreach (var selectorModel in selectorModels)
			{
				model.Selectors.Add(selectorModel);
			}
		}
	}
}