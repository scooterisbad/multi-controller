﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace multi_controller.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
    internal sealed partial class KeyMaps : global::System.Configuration.ApplicationSettingsBase {
        
        private static KeyMaps defaultInstance = ((KeyMaps)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new KeyMaps())));
        
        public static KeyMaps Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("87, 0, 0")]
        public global::multi_controller.KeyMap Forward {
            get {
                return ((global::multi_controller.KeyMap)(this["Forward"]));
            }
            set {
                this["Forward"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("65, 0, 0")]
        public global::multi_controller.KeyMap Left {
            get {
                return ((global::multi_controller.KeyMap)(this["Left"]));
            }
            set {
                this["Left"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("83, 0, 0")]
        public global::multi_controller.KeyMap Back {
            get {
                return ((global::multi_controller.KeyMap)(this["Back"]));
            }
            set {
                this["Back"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("68, 0, 0")]
        public global::multi_controller.KeyMap Right {
            get {
                return ((global::multi_controller.KeyMap)(this["Right"]));
            }
            set {
                this["Right"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("32, 0, 0")]
        public global::multi_controller.KeyMap Jump {
            get {
                return ((global::multi_controller.KeyMap)(this["Jump"]));
            }
            set {
                this["Jump"] = value;
            }
        }
    }
}