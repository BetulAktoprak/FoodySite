using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodySite.UI.Filters
{
	public class GlobalException : ExceptionFilterAttribute
	{
		public override void OnException(ExceptionContext context)
		{
			if (context.Exception.Message != null)
			{
				string message = context.Exception.Message;
				context.Result = new RedirectResult("/Home/Error"); 
			}
		}
	}
}
