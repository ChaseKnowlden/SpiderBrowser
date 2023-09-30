﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EdgeCef
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public bool newRuntimeEventHandled = false;

        public App()
        {
            InitializeComponent();
            this.Resources["AdditionalArgs"] = "--enable-features=ThirdPartyStoragePartitioning,PartitionedCookies";
        }
    }
}
