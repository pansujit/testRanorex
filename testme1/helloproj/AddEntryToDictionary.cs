﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace helloproj
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddEntryToDictionary recording.
    /// </summary>
    [TestModule("c8420901-2f31-4614-9e7c-c2342fb677d5", ModuleType.Recording, 1)]
    public partial class AddEntryToDictionary : ITestModule
    {
        /// <summary>
        /// Holds an instance of the helloprojRepository repository.
        /// </summary>
        public static helloprojRepository repo = helloprojRepository.Instance;

        static AddEntryToDictionary instance = new AddEntryToDictionary();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddEntryToDictionary()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddEntryToDictionary Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.5")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.5")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANDictionaryManager.EnglishSourceLanguage' at 70;11.", repo.SYSTRANDictionaryManager.EnglishSourceLanguageInfo, new RecordItemIndex(0));
            repo.SYSTRANDictionaryManager.EnglishSourceLanguage.Click("70;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'thank you' with focus on 'SYSTRANDictionaryManager.Row0'.", repo.SYSTRANDictionaryManager.Row0Info, new RecordItemIndex(1));
            repo.SYSTRANDictionaryManager.Row0.PressKeys("thank you");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANDictionaryManager.FrenchTargetLanguage' at 51;13.", repo.SYSTRANDictionaryManager.FrenchTargetLanguageInfo, new RecordItemIndex(2));
            repo.SYSTRANDictionaryManager.FrenchTargetLanguage.Click("51;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'merci' with focus on 'SYSTRANDictionaryManager.Row0'.", repo.SYSTRANDictionaryManager.Row0Info, new RecordItemIndex(3));
            repo.SYSTRANDictionaryManager.Row0.PressKeys("merci");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANDictionaryManager.Save' at 15;12.", repo.SYSTRANDictionaryManager.SaveInfo, new RecordItemIndex(4));
            repo.SYSTRANDictionaryManager.Save.Click("15;12");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
