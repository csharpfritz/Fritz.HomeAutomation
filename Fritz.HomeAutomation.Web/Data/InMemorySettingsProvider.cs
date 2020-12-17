using Fritz.HomeAutomation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fritz.HomeAutomation.Web.Data
{
	public class InMemorySettingsProvider : ISettingsProvider
	{

		private static readonly Dictionary<string, IDictionary<string, object>> _DataStore = new Dictionary<string, IDictionary<string, object>>() {

			{"System Settings", new Dictionary<string,object> {
				{"BackgroundImage", "snowyHome.gif" }
			} }

		};


		/// <inheritdoc/>
		public IDictionary<string, object> GetSettingsForWidget(string nameOfWidget)
		{

			return _DataStore[nameOfWidget];

		}


		/// <inheritdoc/>
		public void SaveSettingsForWidget(string nameOfWidget, IDictionary<string, object> settings)
		{
			_DataStore[nameOfWidget] = settings;
		}

	}
}
