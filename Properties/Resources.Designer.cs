﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileReadingLibrary.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FileReadingLibrary.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Dit is een encrypted text file.
        /// </summary>
        internal static string EncryptedTextFile {
            get {
                return ResourceManager.GetString("EncryptedTextFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;note&gt;
        ///  &lt;to&gt;Ordina&lt;/to&gt;
        ///  &lt;from&gt;Atif&lt;/from&gt;
        ///  &lt;heading&gt;Sollicitatie&lt;/heading&gt;
        ///  &lt;body&gt;.NET Traineeship&lt;/body&gt;
        ///&lt;/note&gt;.
        /// </summary>
        internal static string EncryptedXMLFile {
            get {
                return ResourceManager.GetString("EncryptedXMLFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;note&gt;
        ///  &lt;to&gt;Tove&lt;/to&gt;
        ///  &lt;from&gt;Jani&lt;/from&gt;
        ///  &lt;heading&gt;Reminder&lt;/heading&gt;
        ///  &lt;body&gt;Don&apos;t forget me this weekend!&lt;/body&gt;
        ///&lt;/note&gt;.
        /// </summary>
        internal static string TestXML {
            get {
                return ResourceManager.GetString("TestXML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hallo ik ben atif.
        /// </summary>
        internal static string TextFile {
            get {
                return ResourceManager.GetString("TextFile", resourceCulture);
            }
        }
    }
}
