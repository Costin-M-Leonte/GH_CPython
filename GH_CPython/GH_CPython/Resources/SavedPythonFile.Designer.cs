﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GH_CPython.Resources {
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
    internal class SavedPythonFile {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SavedPythonFile() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GH_CPython.Resources.SavedPythonFile", typeof(SavedPythonFile).Assembly);
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
        ///   Looks up a localized string similar to &lt;!-- syntaxdefinition for Python by Steve Dower --&gt;
        ///
        ///&lt;SyntaxDefinition name=&quot;Python&quot; extensions=&quot;.py&quot;&gt;
        ///
        ///    &lt;Environment&gt;
        ///        &lt;Custom name=&quot;TypeReference&quot; bold=&quot;false&quot; italic=&quot;false&quot; color=&quot;#04ABAB&quot; /&gt;
        ///        &lt;Custom name=&quot;UnknownEntity&quot; bold=&quot;false&quot; italic=&quot;false&quot; color=&quot;#AB0404&quot; /&gt;
        ///    &lt;/Environment&gt;
        ///
        ///    &lt;Properties&gt;
        ///        &lt;Property name=&quot;LineComment&quot; value=&quot;#&quot;/&gt;
        ///    &lt;/Properties&gt;
        ///
        ///    &lt;Digits name=&quot;Digits&quot; bold=&quot;false&quot; italic=&quot;false&quot; color=&quot;DarkBlue&quot;/&gt;
        ///
        ///    &lt;RuleSets&gt;
        ///        &lt;Rul [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string hl {
            get {
                return ResourceManager.GetString("hl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string SavedPythonData {
            get {
                return ResourceManager.GetString("SavedPythonData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///
        ///
        ///import xml.etree.cElementTree as ET
        ///import sys
        ///
        ///data = {##data##}
        ///
        ///root = ET.Element(&quot;result&quot;)
        ///
        ///if(sys.version_info[0]==2):
        ///    for k, val in data.iteritems():
        ///        ET.SubElement(root,k).text = str(val)
        ///
        ///elif(sys.version_info[0]==3):
        ///    for k, val in data.items():
        ///        ET.SubElement(root,k).text = str(val)
        ///
        ///tree = ET.ElementTree(root)
        ///tree.write(r&quot;##fileName##&quot;).
        /// </summary>
        internal static string savingFile {
            get {
                return ResourceManager.GetString("savingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # -*- coding: utf-8 -*-
        ///&quot;&quot;&quot; 
        ///Python Script
        ///Created on  ##at## 
        ///@author:  ##CreatedBy## 
        ///
        ///[desc]
        ///Description of the plugin Here
        ///Write here any thing... 
        ///[\desc]
        ///
        ///ARGUMENTS:
        ///    _input = descripe your input here, \n this indicates a new line.
        ///
        ///RETURN:
        ///    output_ = indicate your output description here. \n refers to a new line.
        ///
        ///&quot;&quot;&quot;.
        /// </summary>
        internal static string Shellinit {
            get {
                return ResourceManager.GetString("Shellinit", resourceCulture);
            }
        }
    }
}
