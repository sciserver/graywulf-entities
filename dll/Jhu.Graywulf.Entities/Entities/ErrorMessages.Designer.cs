﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jhu.Graywulf.Entities {
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
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Jhu.Graywulf.Entities.ErrorMessages", typeof(ErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to Access denied..
        /// </summary>
        internal static string AccessDenied {
            get {
                return ResourceManager.GetString("AccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection is already open..
        /// </summary>
        internal static string ConnectionAlreadyOpen {
            get {
                return ResourceManager.GetString("ConnectionAlreadyOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection is not open..
        /// </summary>
        internal static string ConnectionNotOpen {
            get {
                return ResourceManager.GetString("ConnectionNotOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid context. Is it already disposed?.
        /// </summary>
        internal static string ContextInvalid {
            get {
                return ResourceManager.GetString("ContextInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate key column &apos;{0}&apos; defined on type &apos;{1}&apos;..
        /// </summary>
        internal static string DuplicateKeyColumn {
            get {
                return ResourceManager.GetString("DuplicateKeyColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error creating entity..
        /// </summary>
        internal static string ErrorCreateEntity {
            get {
                return ResourceManager.GetString("ErrorCreateEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error deleting entity..
        /// </summary>
        internal static string ErrorDeleteEntity {
            get {
                return ResourceManager.GetString("ErrorDeleteEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error modifying entity..
        /// </summary>
        internal static string ErrorModifyEntity {
            get {
                return ResourceManager.GetString("ErrorModifyEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type of column &apos;{0}&apos; defined on type &apos;{1}&apos; is invalid..
        /// </summary>
        internal static string InvalidColumnType {
            get {
                return ResourceManager.GetString("InvalidColumnType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot reflect type &apos;{0}&apos;: no DbTable attribute found..
        /// </summary>
        internal static string NoDbTableAttributeFound {
            get {
                return ResourceManager.GetString("NoDbTableAttributeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The query returned no results..
        /// </summary>
        internal static string NoResults {
            get {
                return ResourceManager.GetString("NoResults", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Principal type does not support SQL-level access control. Please inherit from Jhu.Graywulf.AccessControl.Principal..
        /// </summary>
        internal static string NoSqlPrincipal {
            get {
                return ResourceManager.GetString("NoSqlPrincipal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot reflect type &apos;{0}&apos;: no table class found..
        /// </summary>
        internal static string NoTableClassFound {
            get {
                return ResourceManager.GetString("NoTableClassFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction is already open..
        /// </summary>
        internal static string TransactionAlreadyOpen {
            get {
                return ResourceManager.GetString("TransactionAlreadyOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction is not open..
        /// </summary>
        internal static string TransactionNotOpen {
            get {
                return ResourceManager.GetString("TransactionNotOpen", resourceCulture);
            }
        }
    }
}
