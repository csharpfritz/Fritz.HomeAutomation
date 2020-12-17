using Fritz.HomeAutomation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fritz.HomeAutomation.Web.Components
{
	public class System_Manager : BaseSettingsManager
	{
		public System_Manager(ISettingsProvider settingsProvider) : base(settingsProvider)
		{
		}

		public override string Name => "System Settings";

		public string BackgroundImage {
			get { return Settings[nameof(BackgroundImage)].ToString();  }
			set {
				var settings = Settings;
				settings[nameof(BackgroundImage)] = value;
				Settings = settings;
			}
		}

		public decimal BackgroundOpacity {
			get { return (decimal)Settings[nameof(BackgroundOpacity)]; }
			set
			{
				var settings = Settings;
				settings[nameof(BackgroundOpacity)] = value;
				Settings = settings;
			}
		}

	}
}
