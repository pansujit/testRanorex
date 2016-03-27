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
    ///The CreateDictionary recording.
    /// </summary>
    [TestModule("15dac2b0-2ace-4fb4-b5ca-21147abeda91", ModuleType.Recording, 1)]
    public partial class CreateDictionary : ITestModule
    {
        /// <summary>
        /// Holds an instance of the helloprojRepository repository.
        /// </summary>
        public static helloprojRepository repo = helloprojRepository.Instance;

        static CreateDictionary instance = new CreateDictionary();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateDictionary()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateDictionary Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DictionaryPropertiesBaseForm.TextEditorEditArea' at 81;7.", repo.DictionaryPropertiesBaseForm.TextEditorEditAreaInfo, new RecordItemIndex(0));
            repo.DictionaryPropertiesBaseForm.TextEditorEditArea.Click("81;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'hello' with focus on 'DictionaryPropertiesBaseForm.TxtDictName'.", repo.DictionaryPropertiesBaseForm.TxtDictNameInfo, new RecordItemIndex(1));
            repo.DictionaryPropertiesBaseForm.TxtDictName.PressKeys("hello");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DictionaryPropertiesBaseForm.TextEditorEditArea1' at 62;9.", repo.DictionaryPropertiesBaseForm.TextEditorEditArea1Info, new RecordItemIndex(2));
            repo.DictionaryPropertiesBaseForm.TextEditorEditArea1.Click("62;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'sujit' with focus on 'DictionaryPropertiesBaseForm.TxtAuthor'.", repo.DictionaryPropertiesBaseForm.TxtAuthorInfo, new RecordItemIndex(3));
            repo.DictionaryPropertiesBaseForm.TxtAuthor.PressKeys("sujit");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DictionaryPropertiesBaseForm.ButtonEditorDropdownButton2' at 9;13.", repo.DictionaryPropertiesBaseForm.ButtonEditorDropdownButton2Info, new RecordItemIndex(4));
            repo.DictionaryPropertiesBaseForm.ButtonEditorDropdownButton2.Click("9;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SystranDictionaryManager1.ListItemValuelistValueListItem0' at 153;10.", repo.SystranDictionaryManager1.ListItemValuelistValueListItem0Info, new RecordItemIndex(5));
            repo.SystranDictionaryManager1.ListItemValuelistValueListItem0.Click("153;10");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
