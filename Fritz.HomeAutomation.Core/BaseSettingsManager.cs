using System.Collections.Generic;

namespace Fritz.HomeAutomation.Core
{
	public class BaseSettingsManager : ISettingsManager
	{
		private readonly ISettingsProvider _SettingsProvider;

		protected BaseSettingsManager(ISettingsProvider settingsProvider)
		{
			_SettingsProvider = settingsProvider;
		}

		public virtual string Name { get; }

		public IDictionary<string,object> Settings { 
			get { return _SettingsProvider.GetSettingsForWidget(Name); }
			set { _SettingsProvider.SaveSettingsForWidget(Name, value); }
		}
	}

}
