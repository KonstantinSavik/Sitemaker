﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
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
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sitemaker.Resources.Resource", typeof(Resource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Админ.
        /// </summary>
        public static string Admin {
            get {
                return ResourceManager.GetString("Admin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Выберите страну.
        /// </summary>
        public static string ChooseLang {
            get {
                return ResourceManager.GetString("ChooseLang", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Страна.
        /// </summary>
        public static string Country {
            get {
                return ResourceManager.GetString("Country", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Поле &quot;Страна&quot; должно быть заполнено.
        /// </summary>
        public static string CountryRequired {
            get {
                return ResourceManager.GetString("CountryRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Добавить нового пользователя.
        /// </summary>
        public static string CreateLink {
            get {
                return ResourceManager.GetString("CreateLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Создать сайт.
        /// </summary>
        public static string CreateSite {
            get {
                return ResourceManager.GetString("CreateSite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Список пользователей.
        /// </summary>
        public static string IndexHeader {
            get {
                return ResourceManager.GetString("IndexHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Имя.
        /// </summary>
        public static string Name {
            get {
                return ResourceManager.GetString("Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Поле &quot;Имя&quot; должно быть заполнено .
        /// </summary>
        public static string NameRequired {
            get {
                return ResourceManager.GetString("NameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Мои сайты.
        /// </summary>
        public static string ShowMySite {
            get {
                return ResourceManager.GetString("ShowMySite", resourceCulture);
            }
        }
    }
}
