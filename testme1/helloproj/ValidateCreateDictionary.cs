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
    ///The ValidateCreateDictionary recording.
    /// </summary>
    [TestModule("aed90b4e-c812-460d-8531-8b29a402768c", ModuleType.Recording, 1)]
    public partial class ValidateCreateDictionary : ITestModule
    {
        /// <summary>
        /// Holds an instance of the helloprojRepository repository.
        /// </summary>
        public static helloprojRepository repo = helloprojRepository.Instance;

        static ValidateCreateDictionary instance = new ValidateCreateDictionary();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateCreateDictionary()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateCreateDictionary Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='[EN-FR] hello') on item 'SYSTRANDictionaryManager.SdmWindowOpen.TreeItemENFRHello'.", repo.SYSTRANDictionaryManager.SdmWindowOpen.TreeItemENFRHelloInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.SYSTRANDictionaryManager.SdmWindowOpen.TreeItemENFRHelloInfo, "Text", "[EN-FR] hello");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Dictionary type:') on item 'SYSTRANDictionaryManager.SdmWindowOpen.DictionaryType'.", repo.SYSTRANDictionaryManager.SdmWindowOpen.DictionaryTypeInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.SYSTRANDictionaryManager.SdmWindowOpen.DictionaryTypeInfo, "Text", "Dictionary type:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='User Dictionaries') on item 'SYSTRANDictionaryManager.SdmWindowOpen.UserDictionaries'.", repo.SYSTRANDictionaryManager.SdmWindowOpen.UserDictionariesInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.SYSTRANDictionaryManager.SdmWindowOpen.UserDictionariesInfo, "Text", "User Dictionaries");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Author:') on item 'SYSTRANDictionaryManager.SdmWindowOpen.Author'.", repo.SYSTRANDictionaryManager.SdmWindowOpen.AuthorInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.SYSTRANDictionaryManager.SdmWindowOpen.AuthorInfo, "Text", "Author:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='sujit') on item 'SYSTRANDictionaryManager.SdmWindowOpen.Sujit'.", repo.SYSTRANDictionaryManager.SdmWindowOpen.SujitInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.SYSTRANDictionaryManager.SdmWindowOpen.SujitInfo, "Text", "sujit");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
