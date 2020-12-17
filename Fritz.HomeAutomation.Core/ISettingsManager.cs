using System;
using System.Collections.Generic;

namespace Fritz.HomeAutomation.Core
{

	/// <summary>
	/// Defines how to trigger and run background services for a widget
	/// </summary>
	public interface ISettingsManager
	{

		/// <summary>
		/// The name of the widget to display
		/// </summary>
		string Name { get; }

		IDictionary<string, object> Settings { get; }

	}

}
