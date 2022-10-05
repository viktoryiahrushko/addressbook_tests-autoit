﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class ApplicationManager
    {
        public static string WINTITLE = "Free Address Book";
        private GroupHelper groupHelper;
        private AutoItX3 aux;
        public ApplicationManager()
        {
            aux = new AutoItX3();
            aux.Run(@"C:\Tools\FreeAddressBookPortable\AddressBook", "", aux.SW_SHOW);
            aux.WinWait(WINTITLE);
            aux.WinActivate(WINTITLE);
            aux.WinWaitActive(WINTITLE);
            groupHelper = new GroupHelper(this);
        }

        public void Stop()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.1114f8110");

        }

        public AutoItX3 Aux
        {
            get
            {
                return aux;
            }
        }
        public GroupHelper Groups { 
        get {
            return groupHelper;
        
        }
        }

    }
}
