﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.4927
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Misuzilla.Applications.AppleWirelessKeyboardHelper.Resources {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Misuzilla.Applications.AppleWirelessKeyboardHelper.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   import clr
        ///
        ///from System import *
        ///from System.Diagnostics import Process
        ///from System.Runtime.InteropServices import Marshal
        ///from System.Windows.Forms import *
        ///from Misuzilla.Applications.AppleWirelessKeyboardHelper import Program, Util
        ///
        ///# Master Volume Control
        ///clr.AddReferenceByPartialName(&quot;MasterVolumeControlLibrary&quot;)
        ///from MasterVolumeControlLibrary import MasterVolumeControl
        ///volControl = MasterVolumeControl.GetControl()
        ///
        ///def OnLoad(sender, e):
        ///  pass
        ///
        ///def OnUnload(sender, e):
        ///  volControl. [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DefaultPythonScript {
            get {
                return ResourceManager.GetString("DefaultPythonScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Apple Wireless Keyboard connected. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string KeyboardConnected {
            get {
                return ResourceManager.GetString("KeyboardConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Apple Wireless Keyboard disconnected. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string KeyboardDisconnected {
            get {
                return ResourceManager.GetString("KeyboardDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Apple Wireless Keyboard is not connected. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string KeyboardNotConnected {
            get {
                return ResourceManager.GetString("KeyboardNotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   E&amp;xit Apple Wireless Keyboard Helper に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MenuItemExit {
            get {
                return ResourceManager.GetString("MenuItemExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   &amp;Reload key configuration scripts に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MenuItemReloadScripts {
            get {
                return ResourceManager.GetString("MenuItemReloadScripts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   An error occurred while loading script.
        ///
        ///Path: {0}
        ///Reason:
        ///{1} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ScriptException {
            get {
                return ResourceManager.GetString("ScriptException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Scripts reloaded. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ScriptsLoaded {
            get {
                return ResourceManager.GetString("ScriptsLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   An error occurred while loading script.
        ///
        ///Path: {0}
        ///Line: {1}, Column: {2}
        ///Reason:
        ///{3} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ScriptSyntaxException {
            get {
                return ResourceManager.GetString("ScriptSyntaxException", resourceCulture);
            }
        }
    }
}
