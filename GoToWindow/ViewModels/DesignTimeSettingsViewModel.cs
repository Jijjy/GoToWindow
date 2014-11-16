﻿using GoToWindow.Api;
using System.Collections.Generic;

namespace GoToWindow.ViewModels
{
	public class DesignTimeSettingsViewModel : SettingsViewModel
	{	
		public DesignTimeSettingsViewModel()
		{
			ShortcutPreset = ShortcutPresets.Custom;
			ShortcutControlKey1 = KeyboardControlKeys.Win;
			ShortcutKey = KeyboardVirtualKeys.Console;
			ShortcutPressesBeforeOpen = 1;

			Version = "0.0.0";
			Plugins = new List<SettingsPluginViewModel>
			{
				new SettingsPluginViewModel{Id = "plugin-1", Name="Plugin 1", Enabled=true},
				new SettingsPluginViewModel{Id = "plugin-2", Name="Plugin 2", Enabled=false}
			};
			WindowListSingleClick = true;
			NoElevatedPrivilegesWarning = true;
			LatestAvailableRelease = "9.9.9";
			UpdateAvailable = CheckForUpdatesStatus.UpdateAvailable;
		}
	}
}
