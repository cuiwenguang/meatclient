﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetDimension.NanUI;

namespace MeatClient
{
    public partial class FrameMain : WinFormium
    {
        public FrameMain()
            : base(System.Configuration.ConfigurationManager.AppSettings["ServiceUrl"])
        {
            InitializeComponent();
            LoadHandler.OnLoadEnd += LoadHandler_OnLoadEnd;
            Win.Register(this);
        }

        private void LoadHandler_OnLoadEnd(object sender, Chromium.Event.CfxOnLoadEndEventArgs e)
        {
        }

    }
}
 