using Fritz.HomeAutomation.Web.Components;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fritz.HomeAutomation.Web
{
	public static class WidgetRegistration
	{

		public static IServiceCollection RegisterWidgets(this IServiceCollection services) 
		{

			services.AddTransient<System_Manager>();

			return services;

		}

	}
}
