﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Metamorphic.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Metamorphic.Core.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The given rule definition is not valid..
        /// </summary>
        internal static string Exceptions_Messages_InvalidRuleDefinition {
            get {
                return ResourceManager.GetString("Exceptions_Messages_InvalidRuleDefinition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given signal does not match the current rule..
        /// </summary>
        internal static string Exceptions_Messages_InvalidSignalForRule {
            get {
                return ResourceManager.GetString("Exceptions_Messages_InvalidSignalForRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A parameter required for the action invocation was missing..
        /// </summary>
        internal static string Exceptions_Messages_MissingActionParameter {
            get {
                return ResourceManager.GetString("Exceptions_Messages_MissingActionParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;{0}&apos; required for the action invocation was missing..
        /// </summary>
        internal static string Exceptions_Messages_MissingActionParameter_WithParameterName {
            get {
                return ResourceManager.GetString("Exceptions_Messages_MissingActionParameter_WithParameterName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No parameter with the specified name could be found..
        /// </summary>
        internal static string Exceptions_Messages_ParameterNotFound {
            get {
                return ResourceManager.GetString("Exceptions_Messages_ParameterNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No parameter with the name {0} could be found..
        /// </summary>
        internal static string Exceptions_Messages_ParameterNotFound_WithName {
            get {
                return ResourceManager.GetString("Exceptions_Messages_ParameterNotFound_WithName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to run powershell.exe. Error: {0}.
        /// </summary>
        internal static string PowershellActionbuilder_Error_FailedToRunExe_WithError {
            get {
                return ResourceManager.GetString("PowershellActionbuilder_Error_FailedToRunExe_WithError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: {0}.
        /// </summary>
        internal static string PowershellActionBuilder_ErrorWhileRunningPowershell_WithError {
            get {
                return ResourceManager.GetString("PowershellActionBuilder_ErrorWhileRunningPowershell_WithError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Powershell script finished.
        /// </summary>
        internal static string PowershellActionBuilder_Output_ProcessCompleted {
            get {
                return ResourceManager.GetString("PowershellActionBuilder_Output_ProcessCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output: {0}.
        /// </summary>
        internal static string PowershellActionBuilder_OutputWhileRunning_WithOutput {
            get {
                return ResourceManager.GetString("PowershellActionBuilder_OutputWhileRunning_WithOutput", resourceCulture);
            }
        }
    }
}