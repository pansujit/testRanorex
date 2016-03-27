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

namespace helloproj
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the helloprojRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.5")]
    [RepositoryFolder("e2cfde25-ff44-4911-af4b-7eb8f2effe47")]
    public partial class helloprojRepository : RepoGenBaseFolder
    {
        static helloprojRepository instance = new helloprojRepository();
        helloprojRepositoryFolders.SYSTRANDictionaryManagerAppFolder _systrandictionarymanager;
        helloprojRepositoryFolders.SystranDictionaryManager1AppFolder _systrandictionarymanager1;
        helloprojRepositoryFolders.DictionaryPropertiesBaseFormAppFolder _dictionarypropertiesbaseform;
        helloprojRepositoryFolders.HelloAppFolder _hello;

        /// <summary>
        /// Gets the singleton class instance representing the helloprojRepository element repository.
        /// </summary>
        [RepositoryFolder("e2cfde25-ff44-4911-af4b-7eb8f2effe47")]
        public static helloprojRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public helloprojRepository() 
            : base("helloprojRepository", "/", null, 0, false, "e2cfde25-ff44-4911-af4b-7eb8f2effe47", ".\\RepositoryImages\\helloprojRepositorye2cfde25.rximgres")
        {
            _systrandictionarymanager = new helloprojRepositoryFolders.SYSTRANDictionaryManagerAppFolder(this);
            _systrandictionarymanager1 = new helloprojRepositoryFolders.SystranDictionaryManager1AppFolder(this);
            _dictionarypropertiesbaseform = new helloprojRepositoryFolders.DictionaryPropertiesBaseFormAppFolder(this);
            _hello = new helloprojRepositoryFolders.HelloAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e2cfde25-ff44-4911-af4b-7eb8f2effe47")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SYSTRANDictionaryManager folder.
        /// </summary>
        [RepositoryFolder("f7845a00-81de-4706-9389-3fd5aeca1233")]
        public virtual helloprojRepositoryFolders.SYSTRANDictionaryManagerAppFolder SYSTRANDictionaryManager
        {
            get { return _systrandictionarymanager; }
        }

        /// <summary>
        /// The SystranDictionaryManager1 folder.
        /// </summary>
        [RepositoryFolder("791998b8-5cb8-44df-8ef3-c3cf0670ddf1")]
        public virtual helloprojRepositoryFolders.SystranDictionaryManager1AppFolder SystranDictionaryManager1
        {
            get { return _systrandictionarymanager1; }
        }

        /// <summary>
        /// The DictionaryPropertiesBaseForm folder.
        /// </summary>
        [RepositoryFolder("98ca0ed2-7da1-404e-ae0c-544f3af8b873")]
        public virtual helloprojRepositoryFolders.DictionaryPropertiesBaseFormAppFolder DictionaryPropertiesBaseForm
        {
            get { return _dictionarypropertiesbaseform; }
        }

        /// <summary>
        /// The Hello folder.
        /// </summary>
        [RepositoryFolder("719ea25e-6789-4c52-b8bc-0ff695c7fe56")]
        public virtual helloprojRepositoryFolders.HelloAppFolder Hello
        {
            get { return _hello; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.5")]
    public partial class helloprojRepositoryFolders
    {
        /// <summary>
        /// The SYSTRANDictionaryManagerAppFolder folder.
        /// </summary>
        [RepositoryFolder("f7845a00-81de-4706-9389-3fd5aeca1233")]
        public partial class SYSTRANDictionaryManagerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _fileInfo;
            RepoItemInfo _numberofentries1Info;
            RepoItemInfo _closeInfo;

            /// <summary>
            /// Creates a new SYSTRANDictionaryManager  folder.
            /// </summary>
            public SYSTRANDictionaryManagerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SYSTRANDictionaryManager", "/form[@title~'^SYSTRAN\\ Dictionary\\ Manage']", parentFolder, 30000, null, true, "f7845a00-81de-4706-9389-3fd5aeca1233", "")
            {
                _fileInfo = new RepoItemInfo(this, "File", ".//menubar[@accessiblename='Toolbar']/menuitem[@accessiblename='File']", 30000, null, "fc52f8c5-fc9c-44ec-a41d-8c29303ea8b2");
                _numberofentries1Info = new RepoItemInfo(this, "NumberOfEntries1", "?/?/form[@controlid='1']//container[@accessiblename='DockTop']/toolbar[@accessiblename='Toolbar']/element[@accessiblename='Number of entries: 1']", 30000, null, "64fb644c-bd21-406b-9a18-c12bbc58164e");
                _closeInfo = new RepoItemInfo(this, "Close", "?/?/button[@accessiblename='Close']", 30000, null, "c08fdf09-b033-4689-90f0-24d56ae0bb6c");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f7845a00-81de-4706-9389-3fd5aeca1233")]
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
            [RepositoryItemInfo("f7845a00-81de-4706-9389-3fd5aeca1233")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The File item.
            /// </summary>
            [RepositoryItem("fc52f8c5-fc9c-44ec-a41d-8c29303ea8b2")]
            public virtual Ranorex.MenuItem File
            {
                get
                {
                    return _fileInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The File item info.
            /// </summary>
            [RepositoryItemInfo("fc52f8c5-fc9c-44ec-a41d-8c29303ea8b2")]
            public virtual RepoItemInfo FileInfo
            {
                get
                {
                    return _fileInfo;
                }
            }

            /// <summary>
            /// The NumberOfEntries1 item.
            /// </summary>
            [RepositoryItem("64fb644c-bd21-406b-9a18-c12bbc58164e")]
            public virtual Ranorex.Unknown NumberOfEntries1
            {
                get
                {
                    return _numberofentries1Info.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The NumberOfEntries1 item info.
            /// </summary>
            [RepositoryItemInfo("64fb644c-bd21-406b-9a18-c12bbc58164e")]
            public virtual RepoItemInfo NumberOfEntries1Info
            {
                get
                {
                    return _numberofentries1Info;
                }
            }

            /// <summary>
            /// The Close item.
            /// </summary>
            [RepositoryItem("c08fdf09-b033-4689-90f0-24d56ae0bb6c")]
            public virtual Ranorex.Button Close
            {
                get
                {
                    return _closeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Close item info.
            /// </summary>
            [RepositoryItemInfo("c08fdf09-b033-4689-90f0-24d56ae0bb6c")]
            public virtual RepoItemInfo CloseInfo
            {
                get
                {
                    return _closeInfo;
                }
            }
        }

        /// <summary>
        /// The SystranDictionaryManager1AppFolder folder.
        /// </summary>
        [RepositoryFolder("791998b8-5cb8-44df-8ef3-c3cf0670ddf1")]
        public partial class SystranDictionaryManager1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _menupopupInfo;
            RepoItemInfo _listitemvaluelistvaluelistitem2Info;
            RepoItemInfo _listitemvaluelistvaluelistitem0Info;

            /// <summary>
            /// Creates a new SystranDictionaryManager1  folder.
            /// </summary>
            public SystranDictionaryManager1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("SystranDictionaryManager1", "/form[@processname='SystranDictionaryManager' and @controltypename='DropDownForm']", parentFolder, 30000, null, true, "791998b8-5cb8-44df-8ef3-c3cf0670ddf1", "")
            {
                _menupopupInfo = new RepoItemInfo(this, "MenuPopup", "?/?/contextmenu[@accessiblerole='MenuPopup']", 30000, null, "43244df9-5233-48c8-bfb0-81bfa2880e0a");
                _listitemvaluelistvaluelistitem2Info = new RepoItemInfo(this, "ListItemValuelistValueListItem2", "?/?/listitem[@automationid='[valuelist] ValueListItem 2']", 30000, null, "730cdbd9-e9d0-4323-a1d1-88e41aa1a641");
                _listitemvaluelistvaluelistitem0Info = new RepoItemInfo(this, "ListItemValuelistValueListItem0", "?/?/listitem[@automationid='[valuelist] ValueListItem 0']", 30000, null, "b1dc373e-0d66-436c-8410-53b257fdb84d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("791998b8-5cb8-44df-8ef3-c3cf0670ddf1")]
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
            [RepositoryItemInfo("791998b8-5cb8-44df-8ef3-c3cf0670ddf1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MenuPopup item.
            /// </summary>
            [RepositoryItem("43244df9-5233-48c8-bfb0-81bfa2880e0a")]
            public virtual Ranorex.ContextMenu MenuPopup
            {
                get
                {
                    return _menupopupInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The MenuPopup item info.
            /// </summary>
            [RepositoryItemInfo("43244df9-5233-48c8-bfb0-81bfa2880e0a")]
            public virtual RepoItemInfo MenuPopupInfo
            {
                get
                {
                    return _menupopupInfo;
                }
            }

            /// <summary>
            /// The ListItemValuelistValueListItem2 item.
            /// </summary>
            [RepositoryItem("730cdbd9-e9d0-4323-a1d1-88e41aa1a641")]
            public virtual Ranorex.ListItem ListItemValuelistValueListItem2
            {
                get
                {
                    return _listitemvaluelistvaluelistitem2Info.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ListItemValuelistValueListItem2 item info.
            /// </summary>
            [RepositoryItemInfo("730cdbd9-e9d0-4323-a1d1-88e41aa1a641")]
            public virtual RepoItemInfo ListItemValuelistValueListItem2Info
            {
                get
                {
                    return _listitemvaluelistvaluelistitem2Info;
                }
            }

            /// <summary>
            /// The ListItemValuelistValueListItem0 item.
            /// </summary>
            [RepositoryItem("b1dc373e-0d66-436c-8410-53b257fdb84d")]
            public virtual Ranorex.ListItem ListItemValuelistValueListItem0
            {
                get
                {
                    return _listitemvaluelistvaluelistitem0Info.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ListItemValuelistValueListItem0 item info.
            /// </summary>
            [RepositoryItemInfo("b1dc373e-0d66-436c-8410-53b257fdb84d")]
            public virtual RepoItemInfo ListItemValuelistValueListItem0Info
            {
                get
                {
                    return _listitemvaluelistvaluelistitem0Info;
                }
            }
        }

        /// <summary>
        /// The DictionaryPropertiesBaseFormAppFolder folder.
        /// </summary>
        [RepositoryFolder("98ca0ed2-7da1-404e-ae0c-544f3af8b873")]
        public partial class DictionaryPropertiesBaseFormAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttoneditordropdownbuttonInfo;
            RepoItemInfo _texteditoreditareaInfo;
            RepoItemInfo _txtdictnameInfo;
            RepoItemInfo _buttoneditordropdownbutton1Info;
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new DictionaryPropertiesBaseForm  folder.
            /// </summary>
            public DictionaryPropertiesBaseFormAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DictionaryPropertiesBaseForm", "/form[@controlname='DictionaryPropertiesBaseForm']", parentFolder, 30000, null, true, "98ca0ed2-7da1-404e-ae0c-544f3af8b873", "")
            {
                _buttoneditordropdownbuttonInfo = new RepoItemInfo(this, "ButtonEditorDropdownButton", "element[@controlname='cbDictType']/button[@automationid='[Editor] dropdown button']", 30000, null, "1c011f33-182f-456e-963b-be0ab2b84e0a");
                _texteditoreditareaInfo = new RepoItemInfo(this, "TextEditorEditArea", "element[@controlname='txtDictName']/text[@automationid='[Editor] Edit Area']", 30000, null, "904d0c8a-bb2b-45b6-b520-c5061e8b199b");
                _txtdictnameInfo = new RepoItemInfo(this, "TxtDictName", "element[@controlname='txtDictName']", 30000, null, "3dc5d80a-a5ff-4865-8207-41a95122387e");
                _buttoneditordropdownbutton1Info = new RepoItemInfo(this, "ButtonEditorDropdownButton1", "element[@controlname='cbTrgLang']/button[@automationid='[Editor] dropdown button']", 30000, null, "9497a5b2-c423-49f2-aa31-60dd0b81166d");
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "?/?/button[@accessiblename='OK']", 30000, null, "11ca7e80-ac75-424d-a585-76c27164c6de");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("98ca0ed2-7da1-404e-ae0c-544f3af8b873")]
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
            [RepositoryItemInfo("98ca0ed2-7da1-404e-ae0c-544f3af8b873")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonEditorDropdownButton item.
            /// </summary>
            [RepositoryItem("1c011f33-182f-456e-963b-be0ab2b84e0a")]
            public virtual Ranorex.Button ButtonEditorDropdownButton
            {
                get
                {
                    return _buttoneditordropdownbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonEditorDropdownButton item info.
            /// </summary>
            [RepositoryItemInfo("1c011f33-182f-456e-963b-be0ab2b84e0a")]
            public virtual RepoItemInfo ButtonEditorDropdownButtonInfo
            {
                get
                {
                    return _buttoneditordropdownbuttonInfo;
                }
            }

            /// <summary>
            /// The TextEditorEditArea item.
            /// </summary>
            [RepositoryItem("904d0c8a-bb2b-45b6-b520-c5061e8b199b")]
            public virtual Ranorex.Text TextEditorEditArea
            {
                get
                {
                    return _texteditoreditareaInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TextEditorEditArea item info.
            /// </summary>
            [RepositoryItemInfo("904d0c8a-bb2b-45b6-b520-c5061e8b199b")]
            public virtual RepoItemInfo TextEditorEditAreaInfo
            {
                get
                {
                    return _texteditoreditareaInfo;
                }
            }

            /// <summary>
            /// The TxtDictName item.
            /// </summary>
            [RepositoryItem("3dc5d80a-a5ff-4865-8207-41a95122387e")]
            public virtual Ranorex.Unknown TxtDictName
            {
                get
                {
                    return _txtdictnameInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The TxtDictName item info.
            /// </summary>
            [RepositoryItemInfo("3dc5d80a-a5ff-4865-8207-41a95122387e")]
            public virtual RepoItemInfo TxtDictNameInfo
            {
                get
                {
                    return _txtdictnameInfo;
                }
            }

            /// <summary>
            /// The ButtonEditorDropdownButton1 item.
            /// </summary>
            [RepositoryItem("9497a5b2-c423-49f2-aa31-60dd0b81166d")]
            public virtual Ranorex.Button ButtonEditorDropdownButton1
            {
                get
                {
                    return _buttoneditordropdownbutton1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonEditorDropdownButton1 item info.
            /// </summary>
            [RepositoryItemInfo("9497a5b2-c423-49f2-aa31-60dd0b81166d")]
            public virtual RepoItemInfo ButtonEditorDropdownButton1Info
            {
                get
                {
                    return _buttoneditordropdownbutton1Info;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("11ca7e80-ac75-424d-a585-76c27164c6de")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("11ca7e80-ac75-424d-a585-76c27164c6de")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

        /// <summary>
        /// The HelloAppFolder folder.
        /// </summary>
        [RepositoryFolder("719ea25e-6789-4c52-b8bc-0ff695c7fe56")]
        public partial class HelloAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonnoInfo;

            /// <summary>
            /// Creates a new Hello  folder.
            /// </summary>
            public HelloAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Hello", "/form[@title='hello']", parentFolder, 30000, null, true, "719ea25e-6789-4c52-b8bc-0ff695c7fe56", "")
            {
                _buttonnoInfo = new RepoItemInfo(this, "ButtonNo", "button[@text='&No']", 30000, null, "a897d18d-82ed-42e4-a2c3-8862aed2ff47");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("719ea25e-6789-4c52-b8bc-0ff695c7fe56")]
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
            [RepositoryItemInfo("719ea25e-6789-4c52-b8bc-0ff695c7fe56")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonNo item.
            /// </summary>
            [RepositoryItem("a897d18d-82ed-42e4-a2c3-8862aed2ff47")]
            public virtual Ranorex.Button ButtonNo
            {
                get
                {
                    return _buttonnoInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonNo item info.
            /// </summary>
            [RepositoryItemInfo("a897d18d-82ed-42e4-a2c3-8862aed2ff47")]
            public virtual RepoItemInfo ButtonNoInfo
            {
                get
                {
                    return _buttonnoInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}