﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarcinS {
    using System;
    
    
    /// <summary>
    ///   Klasa zasobu wymagająca zdefiniowania typu do wyszukiwania zlokalizowanych ciągów itd.
    /// </summary>
    // Ta klasa została automatycznie wygenerowana za pomocą klasy StronglyTypedResourceBuilder
    // przez narzędzie, takie jak ResGen lub Visual Studio.
    // Aby dodać lub usunąć składową, edytuj plik ResX, a następnie ponownie uruchom narzędzie ResGen
    // z opcją /str lub ponownie utwórz projekt VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        /// Zwraca buforowane wystąpienie ResourceManager używane przez tę klasę.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MarcinS.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Przesłania właściwość CurrentUICulture bieżącego wątku dla wszystkich
        ///   przypadków przeszukiwania zasobów za pomocą tej klasy zasobów wymagającej zdefiniowania typu.
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
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] berlin {
            get {
                object obj = ResourceManager.GetObject("berlin", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] miami {
            get {
                object obj = ResourceManager.GetObject("miami", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] pekin {
            get {
                object obj = ResourceManager.GetObject("pekin", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        ///   Wyszukuje zlokalizowany zasób typu System.IO.UnmanagedMemoryStream podobny do zasobu System.IO.MemoryStream.
        /// </summary>
        public static System.IO.UnmanagedMemoryStream sound {
            get {
                return ResourceManager.GetStream("sound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] victoria {
            get {
                object obj = ResourceManager.GetObject("victoria", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
