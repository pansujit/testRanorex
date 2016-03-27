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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace testme1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the testme1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.5")]
    [RepositoryFolder("338246f2-2df2-482d-87ef-a15469631c13")]
    public partial class testme1Repository : RepoGenBaseFolder
    {
        static testme1Repository instance = new testme1Repository();
        testme1RepositoryFolders.SYSTRANInteractiveTranslatorAppFolder _systraninteractivetranslator;
        testme1RepositoryFolders.SYSTRANInteractiveTranslator1AppFolder _systraninteractivetranslator1;
        testme1RepositoryFolders.SYSTRANInteractiveTranslator2AppFolder _systraninteractivetranslator2;
        testme1RepositoryFolders.RanorexStudioProjectsAppFolder _ranorexstudioprojects;
        testme1RepositoryFolders.RanorexConfigJenkinsGoogleChromeAppFolder _ranorexconfigjenkinsgooglechrome;
        testme1RepositoryFolders.CWINDOWSSystem32CmdExeAppFolder _cwindowssystem32cmdexe;
        testme1RepositoryFolders.FMainAppFolder _fmain;

        /// <summary>
        /// Gets the singleton class instance representing the testme1Repository element repository.
        /// </summary>
        [RepositoryFolder("338246f2-2df2-482d-87ef-a15469631c13")]
        public static testme1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public testme1Repository() 
            : base("testme1Repository", "/", null, 0, false, "338246f2-2df2-482d-87ef-a15469631c13", ".\\RepositoryImages\\testme1Repository338246f2.rximgres")
        {
            _systraninteractivetranslator = new testme1RepositoryFolders.SYSTRANInteractiveTranslatorAppFolder(this);
            _systraninteractivetranslator1 = new testme1RepositoryFolders.SYSTRANInteractiveTranslator1AppFolder(this);
            _systraninteractivetranslator2 = new testme1RepositoryFolders.SYSTRANInteractiveTranslator2AppFolder(this);
            _ranorexstudioprojects = new testme1RepositoryFolders.RanorexStudioProjectsAppFolder(this);
            _ranorexconfigjenkinsgooglechrome = new testme1RepositoryFolders.RanorexConfigJenkinsGoogleChromeAppFolder(this);
            _cwindowssystem32cmdexe = new testme1RepositoryFolders.CWINDOWSSystem32CmdExeAppFolder(this);
            _fmain = new testme1RepositoryFolders.FMainAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("338246f2-2df2-482d-87ef-a15469631c13")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SYSTRANInteractiveTranslator folder.
        /// </summary>
        [RepositoryFolder("38cce30d-cdc4-413a-b7f8-9229625a4bb3")]
        public virtual testme1RepositoryFolders.SYSTRANInteractiveTranslatorAppFolder SYSTRANInteractiveTranslator
        {
            get { return _systraninteractivetranslator; }
        }

        /// <summary>
        /// The SYSTRANInteractiveTranslator1 folder.
        /// </summary>
        [RepositoryFolder("6396ce33-dfa6-4db2-9580-55f9155c1f31")]
        public virtual testme1RepositoryFolders.SYSTRANInteractiveTranslator1AppFolder SYSTRANInteractiveTranslator1
        {
            get { return _systraninteractivetranslator1; }
        }

        /// <summary>
        /// The SYSTRANInteractiveTranslator2 folder.
        /// </summary>
        [RepositoryFolder("84056e92-5a88-49a9-a4dd-9fd832444058")]
        public virtual testme1RepositoryFolders.SYSTRANInteractiveTranslator2AppFolder SYSTRANInteractiveTranslator2
        {
            get { return _systraninteractivetranslator2; }
        }

        /// <summary>
        /// The RanorexStudioProjects folder.
        /// </summary>
        [RepositoryFolder("3643fe4e-bbdf-4c52-929c-d76b4130d8b1")]
        public virtual testme1RepositoryFolders.RanorexStudioProjectsAppFolder RanorexStudioProjects
        {
            get { return _ranorexstudioprojects; }
        }

        /// <summary>
        /// The RanorexConfigJenkinsGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("65b3c58c-ac0e-4be6-ab49-a5473e1f0a34")]
        public virtual testme1RepositoryFolders.RanorexConfigJenkinsGoogleChromeAppFolder RanorexConfigJenkinsGoogleChrome
        {
            get { return _ranorexconfigjenkinsgooglechrome; }
        }

        /// <summary>
        /// The CWINDOWSSystem32CmdExe folder.
        /// </summary>
        [RepositoryFolder("aab285d1-3480-4c41-b4e1-4ca4229257d5")]
        public virtual testme1RepositoryFolders.CWINDOWSSystem32CmdExeAppFolder CWINDOWSSystem32CmdExe
        {
            get { return _cwindowssystem32cmdexe; }
        }

        /// <summary>
        /// The FMain folder.
        /// </summary>
        [RepositoryFolder("6f9ad8fb-9bc4-4a47-9eae-099011ef0109")]
        public virtual testme1RepositoryFolders.FMainAppFolder FMain
        {
            get { return _fmain; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.5")]
    public partial class testme1RepositoryFolders
    {
        /// <summary>
        /// The SYSTRANInteractiveTranslatorAppFolder folder.
        /// </summary>
        [RepositoryFolder("38cce30d-cdc4-413a-b7f8-9229625a4bb3")]
        public partial class SYSTRANInteractiveTranslatorAppFolder : RepoGenBaseFolder
        {
            testme1RepositoryFolders.MTranslationOptionsPanelFolder _mtranslationoptionspanel;
            RepoItemInfo _someelementInfo;
            RepoItemInfo _translateInfo;

            /// <summary>
            /// Creates a new SYSTRANInteractiveTranslator  folder.
            /// </summary>
            public SYSTRANInteractiveTranslatorAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SYSTRANInteractiveTranslator", "/form[@wpfnative='True' and @title~'^SYSTRAN\\ Interactive\\ Trans' and @processname='SYSTRAN.InteractiveTranslator']", parentFolder, 30000, null, true, "38cce30d-cdc4-413a-b7f8-9229625a4bb3", "")
            {
                _mtranslationoptionspanel = new testme1RepositoryFolders.MTranslationOptionsPanelFolder(this);
                _someelementInfo = new RepoItemInfo(this, "SomeElement", "container/element[1]/container/element[7]/container[@automationid='root']/element/element[1]/element/container/container[2]/container[@automationid='mTranslationPanel']//container[@automationid='mSrContentControl']/element[@automationid='mResizeSourceControl']//text[@automationid='mSrcRichTextBox']/element[@automationid='border']/container[@automationid='PART_ContentHost']/container[@automationid='Grid']/element[@automationid='PART_ScrollContentPresenter']/element[1]/element", 30000, null, "b0e917e3-5c2e-46ec-a3fd-ed0d006336aa");
                _translateInfo = new RepoItemInfo(this, "Translate", "container/element[1]/container/element[7]/container[@automationid='root']/element/element[1]/element/container/container[1]/button[@automationid='mTranslateButton']/?/?/element[@automationid='contentPresenter']/text[@caption='Translate']", 30000, null, "e2678e19-e55e-4622-b0de-daa39861ac73");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("38cce30d-cdc4-413a-b7f8-9229625a4bb3")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("38cce30d-cdc4-413a-b7f8-9229625a4bb3")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SomeElement item.
            /// </summary>
            [RepositoryItem("b0e917e3-5c2e-46ec-a3fd-ed0d006336aa")]
            public virtual Ranorex.Unknown SomeElement
            {
                get
                {
                    return _someelementInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The SomeElement item info.
            /// </summary>
            [RepositoryItemInfo("b0e917e3-5c2e-46ec-a3fd-ed0d006336aa")]
            public virtual RepoItemInfo SomeElementInfo
            {
                get
                {
                    return _someelementInfo;
                }
            }

            /// <summary>
            /// The Translate item.
            /// </summary>
            [RepositoryItem("e2678e19-e55e-4622-b0de-daa39861ac73")]
            public virtual Ranorex.Text Translate
            {
                get
                {
                    return _translateInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Translate item info.
            /// </summary>
            [RepositoryItemInfo("e2678e19-e55e-4622-b0de-daa39861ac73")]
            public virtual RepoItemInfo TranslateInfo
            {
                get
                {
                    return _translateInfo;
                }
            }

            /// <summary>
            /// The MTranslationOptionsPanel folder.
            /// </summary>
            [RepositoryFolder("4ead8c80-ef32-4ef8-af54-6212bb0c1f9d")]
            public virtual testme1RepositoryFolders.MTranslationOptionsPanelFolder MTranslationOptionsPanel
            {
                get { return _mtranslationoptionspanel; }
            }
        }

        /// <summary>
        /// The MTranslationOptionsPanelFolder folder.
        /// </summary>
        [RepositoryFolder("4ead8c80-ef32-4ef8-af54-6212bb0c1f9d")]
        public partial class MTranslationOptionsPanelFolder : RepoGenBaseFolder
        {
            RepoItemInfo _backgroundInfo;
            RepoItemInfo _btnarrowInfo;
            RepoItemInfo _btnarrow1Info;

            /// <summary>
            /// Creates a new MTranslationOptionsPanel  folder.
            /// </summary>
            public MTranslationOptionsPanelFolder(RepoGenBaseFolder parentFolder) :
                    base("MTranslationOptionsPanel", "container/element[1]/container/element[7]/container[@automationid='root']/element/element[1]/element/container/container[1]/container[@automationid='mTranslationOptionsPanel']", parentFolder, 30000, null, false, "4ead8c80-ef32-4ef8-af54-6212bb0c1f9d", "")
            {
                _backgroundInfo = new RepoItemInfo(this, "Background", ".//combobox[@automationid='mSourceLangComboBox']/container/element[@automationid='ContentPresenterBorder']/?/?/checkbox[@automationid='DropDownToggle']/?/?/element[@automationid='Background']", 30000, null, "0952471f-aa70-449d-a589-156c6dce2645");
                _btnarrowInfo = new RepoItemInfo(this, "BtnArrow", ".//combobox[@automationid='mTargetLangComboBox']/?/?/element[@automationid='ContentPresenterBorder']/?/?/checkbox[@automationid='DropDownToggle']/container/element[8]/element[@automationid='BtnArrow']", 30000, null, "51f29527-420c-4cc8-b1ba-461a51f4a26b");
                _btnarrow1Info = new RepoItemInfo(this, "BtnArrow1", "?/?/element/container/combobox[3]/?/?/element[@automationid='ContentPresenterBorder']/?/?/checkbox[@automationid='DropDownToggle']/container/element[8]/element[@automationid='BtnArrow']", 30000, null, "f6fa3244-eb59-435d-82f4-6c5a2f74f723");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("4ead8c80-ef32-4ef8-af54-6212bb0c1f9d")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("4ead8c80-ef32-4ef8-af54-6212bb0c1f9d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Background item.
            /// </summary>
            [RepositoryItem("0952471f-aa70-449d-a589-156c6dce2645")]
            public virtual Ranorex.Unknown Background
            {
                get
                {
                    return _backgroundInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Background item info.
            /// </summary>
            [RepositoryItemInfo("0952471f-aa70-449d-a589-156c6dce2645")]
            public virtual RepoItemInfo BackgroundInfo
            {
                get
                {
                    return _backgroundInfo;
                }
            }

            /// <summary>
            /// The BtnArrow item.
            /// </summary>
            [RepositoryItem("51f29527-420c-4cc8-b1ba-461a51f4a26b")]
            public virtual Ranorex.Unknown BtnArrow
            {
                get
                {
                    return _btnarrowInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The BtnArrow item info.
            /// </summary>
            [RepositoryItemInfo("51f29527-420c-4cc8-b1ba-461a51f4a26b")]
            public virtual RepoItemInfo BtnArrowInfo
            {
                get
                {
                    return _btnarrowInfo;
                }
            }

            /// <summary>
            /// The BtnArrow1 item.
            /// </summary>
            [RepositoryItem("f6fa3244-eb59-435d-82f4-6c5a2f74f723")]
            public virtual Ranorex.Unknown BtnArrow1
            {
                get
                {
                    return _btnarrow1Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The BtnArrow1 item info.
            /// </summary>
            [RepositoryItemInfo("f6fa3244-eb59-435d-82f4-6c5a2f74f723")]
            public virtual RepoItemInfo BtnArrow1Info
            {
                get
                {
                    return _btnarrow1Info;
                }
            }
        }

        /// <summary>
        /// The SYSTRANInteractiveTranslator1AppFolder folder.
        /// </summary>
        [RepositoryFolder("6396ce33-dfa6-4db2-9580-55f9155c1f31")]
        public partial class SYSTRANInteractiveTranslator1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _englishInfo;
            RepoItemInfo _frenchInfo;
            RepoItemInfo _elementbdInfo;

            /// <summary>
            /// Creates a new SYSTRANInteractiveTranslator1  folder.
            /// </summary>
            public SYSTRANInteractiveTranslator1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("SYSTRANInteractiveTranslator1", "/contextmenu[@processname='SYSTRAN.InteractiveTranslator' and @win32ownerwindowlevel='1']", parentFolder, 30000, null, false, "6396ce33-dfa6-4db2-9580-55f9155c1f31", "")
            {
                _englishInfo = new RepoItemInfo(this, "English", ".//element[@automationid='PopupBorder']/container[@automationid='DropDownScrollViewer']/container[@automationid='Grid']/element[@automationid='PART_ScrollContentPresenter']/list[@automationid='ItemsPresenter']/container/container/container/list[@automationid='ItemsPresenter']/container/listitem[2]/element[@automationid='Bd']/?/?/text[@caption='English']", 30000, null, "addcc5c2-e7c4-4a6c-8499-3287c5250f83");
                _frenchInfo = new RepoItemInfo(this, "French", ".//element[@automationid='PopupBorder']/container[@automationid='DropDownScrollViewer']/container[@automationid='Grid']/element[@automationid='PART_ScrollContentPresenter']/list[@automationid='ItemsPresenter']/container/container/container/list[@automationid='ItemsPresenter']//element[@automationid='Bd']/?/?/text[@caption='French']", 30000, null, "650f81f5-7c51-4234-b17f-3c9418eaf14a");
                _elementbdInfo = new RepoItemInfo(this, "ElementBd", ".//container[@automationid='DropDownScrollViewer']/container[@automationid='Grid']/element[@automationid='PART_ScrollContentPresenter']/list[@automationid='ItemsPresenter']/container/listitem[2]/element[@automationid='Bd']", 30000, null, "f88a1c8f-5237-4c94-9bde-c4a3b7e3425f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6396ce33-dfa6-4db2-9580-55f9155c1f31")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6396ce33-dfa6-4db2-9580-55f9155c1f31")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The English item.
            /// </summary>
            [RepositoryItem("addcc5c2-e7c4-4a6c-8499-3287c5250f83")]
            public virtual Ranorex.Text English
            {
                get
                {
                    return _englishInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The English item info.
            /// </summary>
            [RepositoryItemInfo("addcc5c2-e7c4-4a6c-8499-3287c5250f83")]
            public virtual RepoItemInfo EnglishInfo
            {
                get
                {
                    return _englishInfo;
                }
            }

            /// <summary>
            /// The French item.
            /// </summary>
            [RepositoryItem("650f81f5-7c51-4234-b17f-3c9418eaf14a")]
            public virtual Ranorex.Text French
            {
                get
                {
                    return _frenchInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The French item info.
            /// </summary>
            [RepositoryItemInfo("650f81f5-7c51-4234-b17f-3c9418eaf14a")]
            public virtual RepoItemInfo FrenchInfo
            {
                get
                {
                    return _frenchInfo;
                }
            }

            /// <summary>
            /// The ElementBd item.
            /// </summary>
            [RepositoryItem("f88a1c8f-5237-4c94-9bde-c4a3b7e3425f")]
            public virtual Ranorex.Unknown ElementBd
            {
                get
                {
                    return _elementbdInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The ElementBd item info.
            /// </summary>
            [RepositoryItemInfo("f88a1c8f-5237-4c94-9bde-c4a3b7e3425f")]
            public virtual RepoItemInfo ElementBdInfo
            {
                get
                {
                    return _elementbdInfo;
                }
            }
        }

        /// <summary>
        /// The SYSTRANInteractiveTranslator2AppFolder folder.
        /// </summary>
        [RepositoryFolder("84056e92-5a88-49a9-a4dd-9fd832444058")]
        public partial class SYSTRANInteractiveTranslator2AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _mtgtrichtextboxInfo;
            RepoItemInfo _partcloseInfo;

            /// <summary>
            /// Creates a new SYSTRANInteractiveTranslator2  folder.
            /// </summary>
            public SYSTRANInteractiveTranslator2AppFolder(RepoGenBaseFolder parentFolder) :
                    base("SYSTRANInteractiveTranslator2", "/form[@name~'^SYSTRAN\\ Interactive\\ Trans' and @classname='Window' and @orientation='None']", parentFolder, 30000, null, true, "84056e92-5a88-49a9-a4dd-9fd832444058", "")
            {
                _mtgtrichtextboxInfo = new RepoItemInfo(this, "MTgtRichTextBox", "?/?/text[@automationid='mTgtRichTextBox']", 30000, null, "68caad28-6a4a-43aa-818f-adafcd53e30b");
                _partcloseInfo = new RepoItemInfo(this, "PARTClose", "button[@automationid='PART_Close']", 30000, null, "69a156e6-3fdb-4ecf-aae8-19d74f705c6d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("84056e92-5a88-49a9-a4dd-9fd832444058")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("84056e92-5a88-49a9-a4dd-9fd832444058")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MTgtRichTextBox item.
            /// </summary>
            [RepositoryItem("68caad28-6a4a-43aa-818f-adafcd53e30b")]
            public virtual Ranorex.Text MTgtRichTextBox
            {
                get
                {
                    return _mtgtrichtextboxInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The MTgtRichTextBox item info.
            /// </summary>
            [RepositoryItemInfo("68caad28-6a4a-43aa-818f-adafcd53e30b")]
            public virtual RepoItemInfo MTgtRichTextBoxInfo
            {
                get
                {
                    return _mtgtrichtextboxInfo;
                }
            }

            /// <summary>
            /// The PARTClose item.
            /// </summary>
            [RepositoryItem("69a156e6-3fdb-4ecf-aae8-19d74f705c6d")]
            public virtual Ranorex.Button PARTClose
            {
                get
                {
                    return _partcloseInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PARTClose item info.
            /// </summary>
            [RepositoryItemInfo("69a156e6-3fdb-4ecf-aae8-19d74f705c6d")]
            public virtual RepoItemInfo PARTCloseInfo
            {
                get
                {
                    return _partcloseInfo;
                }
            }
        }

        /// <summary>
        /// The RanorexStudioProjectsAppFolder folder.
        /// </summary>
        [RepositoryFolder("3643fe4e-bbdf-4c52-929c-d76b4130d8b1")]
        public partial class RanorexStudioProjectsAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _minimizerestoreInfo;

            /// <summary>
            /// Creates a new RanorexStudioProjects  folder.
            /// </summary>
            public RanorexStudioProjectsAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RanorexStudioProjects", "/form[@title='RanorexStudio Projects']", parentFolder, 30000, null, true, "3643fe4e-bbdf-4c52-929c-d76b4130d8b1", "")
            {
                _minimizerestoreInfo = new RepoItemInfo(this, "MinimizeRestore", "?/?/button[@automationid='Minimize-Restore']", 30000, null, "556d92ee-c30f-418c-b4ba-0b808730f4a4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3643fe4e-bbdf-4c52-929c-d76b4130d8b1")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3643fe4e-bbdf-4c52-929c-d76b4130d8b1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MinimizeRestore item.
            /// </summary>
            [RepositoryItem("556d92ee-c30f-418c-b4ba-0b808730f4a4")]
            public virtual Ranorex.Button MinimizeRestore
            {
                get
                {
                    return _minimizerestoreInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The MinimizeRestore item info.
            /// </summary>
            [RepositoryItemInfo("556d92ee-c30f-418c-b4ba-0b808730f4a4")]
            public virtual RepoItemInfo MinimizeRestoreInfo
            {
                get
                {
                    return _minimizerestoreInfo;
                }
            }
        }

        /// <summary>
        /// The RanorexConfigJenkinsGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("65b3c58c-ac0e-4be6-ab49-a5473e1f0a34")]
        public partial class RanorexConfigJenkinsGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _clientInfo;

            /// <summary>
            /// Creates a new RanorexConfigJenkinsGoogleChrome  folder.
            /// </summary>
            public RanorexConfigJenkinsGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RanorexConfigJenkinsGoogleChrome", "/form[@title~'^ranorex\\ Config\\ \\[Jenkins]\\ ']", parentFolder, 30000, null, true, "65b3c58c-ac0e-4be6-ab49-a5473e1f0a34", "")
            {
                _clientInfo = new RepoItemInfo(this, "Client", "container[@accessiblename='Google Chrome']/container[2]/container[3]", 30000, null, "fa58228c-fdad-4634-a31f-580869659e06");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("65b3c58c-ac0e-4be6-ab49-a5473e1f0a34")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("65b3c58c-ac0e-4be6-ab49-a5473e1f0a34")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Client item.
            /// </summary>
            [RepositoryItem("fa58228c-fdad-4634-a31f-580869659e06")]
            public virtual Ranorex.Container Client
            {
                get
                {
                    return _clientInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Client item info.
            /// </summary>
            [RepositoryItemInfo("fa58228c-fdad-4634-a31f-580869659e06")]
            public virtual RepoItemInfo ClientInfo
            {
                get
                {
                    return _clientInfo;
                }
            }
        }

        /// <summary>
        /// The CWINDOWSSystem32CmdExeAppFolder folder.
        /// </summary>
        [RepositoryFolder("aab285d1-3480-4c41-b4e1-4ca4229257d5")]
        public partial class CWINDOWSSystem32CmdExeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _minimizeInfo;

            /// <summary>
            /// Creates a new CWINDOWSSystem32CmdExe  folder.
            /// </summary>
            public CWINDOWSSystem32CmdExeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("CWINDOWSSystem32CmdExe", "/form[@title~'^C:\\\\WINDOWS\\\\system32\\\\cmd\\.e']", parentFolder, 30000, null, true, "aab285d1-3480-4c41-b4e1-4ca4229257d5", "")
            {
                _minimizeInfo = new RepoItemInfo(this, "Minimize", "?/?/button[@accessiblename='Minimize']", 30000, null, "ea264bd5-e189-4fb8-a192-73c757930b54");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("aab285d1-3480-4c41-b4e1-4ca4229257d5")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("aab285d1-3480-4c41-b4e1-4ca4229257d5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Minimize item.
            /// </summary>
            [RepositoryItem("ea264bd5-e189-4fb8-a192-73c757930b54")]
            public virtual Ranorex.Button Minimize
            {
                get
                {
                    return _minimizeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Minimize item info.
            /// </summary>
            [RepositoryItemInfo("ea264bd5-e189-4fb8-a192-73c757930b54")]
            public virtual RepoItemInfo MinimizeInfo
            {
                get
                {
                    return _minimizeInfo;
                }
            }
        }

        /// <summary>
        /// The FMainAppFolder folder.
        /// </summary>
        [RepositoryFolder("6f9ad8fb-9bc4-4a47-9eae-099011ef0109")]
        public partial class FMainAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _minimizeInfo;

            /// <summary>
            /// Creates a new FMain  folder.
            /// </summary>
            public FMainAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FMain", "/form[@controlname='fMain']", parentFolder, 30000, null, true, "6f9ad8fb-9bc4-4a47-9eae-099011ef0109", "")
            {
                _minimizeInfo = new RepoItemInfo(this, "Minimize", "?/?/button[@accessiblename='Minimize']", 30000, null, "c6e5d4f5-754b-40ae-a2fb-e2c872a2f31e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6f9ad8fb-9bc4-4a47-9eae-099011ef0109")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6f9ad8fb-9bc4-4a47-9eae-099011ef0109")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Minimize item.
            /// </summary>
            [RepositoryItem("c6e5d4f5-754b-40ae-a2fb-e2c872a2f31e")]
            public virtual Ranorex.Button Minimize
            {
                get
                {
                    return _minimizeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Minimize item info.
            /// </summary>
            [RepositoryItemInfo("c6e5d4f5-754b-40ae-a2fb-e2c872a2f31e")]
            public virtual RepoItemInfo MinimizeInfo
            {
                get
                {
                    return _minimizeInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}