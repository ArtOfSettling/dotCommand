using UnityEditor;
using UnityEngine;
using WellFired.Command.Unity.Runtime.Loaders;

namespace WellFired.Command.Unity.Editor
{   
    public static class Preferences
    {
        private static Settings _currentSettings;

        // Add preferences section named "My Preferences" to the Preferences Window
        [PreferenceItem(".Command")]
        // ReSharper disable once InconsistentNaming
        public static void PreferencesGUI()
        {
            if (_currentSettings == null)
                _currentSettings = SettingsData.Load();

            _currentSettings.Theme = (Theme)EditorGUILayout.EnumPopup("Theme", _currentSettings.Theme);

            if (!GUI.changed) 
                return;

            SettingsData.Save(_currentSettings);
        }
    }
}