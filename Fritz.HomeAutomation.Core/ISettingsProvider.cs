using System.Collections.Generic;

namespace Fritz.HomeAutomation.Core
{
	/// <summary>
	/// Manages the storage of settings for a widget
	/// </summary>
	public interface ISettingsProvider
	{

		/// <summary>
		/// Get all of the settings for the widget requested
		/// </summary>
		/// <param name="nameOfWidget"></param>
		/// <returns></returns>
		IDictionary<string, object> GetSettingsForWidget(string nameOfWidget);

		/// <summary>
		/// Save the settings for the widget specified
		/// </summary>
		/// <param name="nameOfWidget"></param>
		/// <param name="settings"></param>
		void SaveSettingsForWidget(string nameOfWidget, IDictionary<string, object> settings);

	}


}