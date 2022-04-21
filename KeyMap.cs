using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;

namespace multi_controller
{
    [TypeConverter(typeof(KeyMapConverter))]
    [SettingsSerializeAs(SettingsSerializeAs.String)]
    public class KeyMap
    {
        public Keys OutputKey { get; set; }
        public Keys LeftKey { get; set; }
        public Keys RightKey { get; set; }

        public KeyMap() { }

        /// <summary>
        /// Gets the relevant output key
        /// </summary>
        /// <param name="keyCode"></param>
        /// <param name="controlSet"></param>
        /// <returns>The keycode if it exists, -1 if it doesn't exist</returns>
        public static int GetOutputKey(int keyCode, ControlSet controlSet)
        {
            if (controlSet == ControlSet.Left)
            {
                foreach (SettingsProperty settingsProperty in Properties.KeyMaps.Default.Properties)
                {
                    KeyMap map = Properties.KeyMaps.Default[settingsProperty.Name] as KeyMap;
                    if (keyCode == (int)map.LeftKey) 
                    {
                        return (int)map.OutputKey;
                    }
                }
            }
            else if (controlSet == ControlSet.Right)
            {
                foreach (SettingsProperty settingsProperty in Properties.KeyMaps.Default.Properties)
                {
                    KeyMap map = Properties.KeyMaps.Default[settingsProperty.Name] as KeyMap;
                    if (keyCode == (int)map.RightKey)
                    {
                        return (int)map.OutputKey;
                    }
                }
            }
            return -1;
        }
    }

    public class KeyMapConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                string[] parts = ((string)value).Split(new char[] { ',' });
                KeyMap keyMap = new KeyMap();
                keyMap.OutputKey = (Keys)Convert.ToInt32(parts[0]);
                keyMap.LeftKey = (Keys)Convert.ToInt32(parts[1]);
                keyMap.RightKey = (Keys)Convert.ToInt32(parts[2]);
                return keyMap;
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                KeyMap keyMap = value as KeyMap;
                return $"{(int)keyMap.OutputKey}, {(int)keyMap.LeftKey}, {(int)keyMap.RightKey}";
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
