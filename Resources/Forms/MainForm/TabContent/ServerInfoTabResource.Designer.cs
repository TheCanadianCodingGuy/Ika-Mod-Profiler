﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace playtarky.Resources.Forms.MainForm.TabContent {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ServerInfoTabResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ServerInfoTabResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("playtarky.Resources.Forms.MainForm.TabContent.ServerInfoTabResource", typeof(ServerInfoTabResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backend IP.
        /// </summary>
        internal static string backendIp {
            get {
                return ResourceManager.GetString("backendIp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backend Port.
        /// </summary>
        internal static string backendPort {
            get {
                return ResourceManager.GetString("backendPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IP test hehe.
        /// </summary>
        internal static string ip {
            get {
                return ResourceManager.GetString("ip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log Requests.
        /// </summary>
        internal static string logRequests {
            get {
                return ResourceManager.GetString("logRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Port.
        /// </summary>
        internal static string port {
            get {
                return ResourceManager.GetString("port", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebSocket Ping Delay (ms).
        /// </summary>
        internal static string webSocketPingDelayMs {
            get {
                return ResourceManager.GetString("webSocketPingDelayMs", resourceCulture);
            }
        }
    }
}