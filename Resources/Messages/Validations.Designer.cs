﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources.Messages {
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
    public class Validations {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Validations() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Messages.Validations", typeof(Validations).Assembly);
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
        ///   Looks up a localized string similar to Application secret key should be minimum 16 and maximum 64 characters, with at least one uppercase letter, one lowercase letter, one number and one special character!.
        /// </summary>
        public static string ApplicationSecretKey {
            get {
                return ResourceManager.GetString("ApplicationSecretKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not valid!.
        /// </summary>
        public static string CellPhoneNumber {
            get {
                return ResourceManager.GetString("CellPhoneNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} should be equql to {1}!.
        /// </summary>
        public static string Compare {
            get {
                return ResourceManager.GetString("Compare", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email address is not valid!.
        /// </summary>
        public static string EmailAddress {
            get {
                return ResourceManager.GetString("EmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} should be greater than or equal to {1}!.
        /// </summary>
        public static string GreaterThanOrEqualTo {
            get {
                return ResourceManager.GetString("GreaterThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not valid!.
        /// </summary>
        public static string IP {
            get {
                return ResourceManager.GetString("IP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max length of {0} is {1}!.
        /// </summary>
        public static string MaxLength {
            get {
                return ResourceManager.GetString("MaxLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not valid!.
        /// </summary>
        public static string NationalCode {
            get {
                return ResourceManager.GetString("NationalCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password should be minimum eight and maximum twenty characters, with at least one uppercase letter, one lowercase letter, one number and one special character!.
        /// </summary>
        public static string Password {
            get {
                return ResourceManager.GetString("Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can use just A to Z (Upper or Lower), Digits and Underline and should start with just A to Z!.
        /// </summary>
        public static string RegularExpressionAToZDigitsUnderline {
            get {
                return ResourceManager.GetString("RegularExpressionAToZDigitsUnderline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is repetitious!.
        /// </summary>
        public static string Repetitious {
            get {
                return ResourceManager.GetString("Repetitious", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is required!.
        /// </summary>
        public static string Required {
            get {
                return ResourceManager.GetString("Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not valid!.
        /// </summary>
        public static string Url {
            get {
                return ResourceManager.GetString("Url", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not valid!.
        /// </summary>
        public static string Username {
            get {
                return ResourceManager.GetString("Username", resourceCulture);
            }
        }
    }
}
