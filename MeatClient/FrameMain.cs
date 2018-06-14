using System;
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
        BarCodeHook BarCode = new BarCodeHook(); // 条码枪
        string strBarCode = "";
        public FrameMain()
            : base(System.Configuration.ConfigurationManager.AppSettings["ServiceUrl"])
        {
            InitializeComponent();
            LoadHandler.OnLoadEnd += LoadHandler_OnLoadEnd;
            Win.Register(this);
            BarCode.BarCodeEvent += new BarCodeHook.BarCodeDelegate(BarCode_BarCodeEvent);
        }

        private delegate void ShowInfoDelegate(BarCodeHook.BarCodes barCode);
        private void ShowInfo(BarCodeHook.BarCodes barCode)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ShowInfoDelegate(ShowInfo), new object[] { barCode });
            }
            else
            {
                if (barCode.IsValid)
                {
                    ExecuteJavascript("setBarCode('" + barCode.BarCode + "')");
                    //MessageBox.Show(barCode.BarCode);                   
                }  
            }
        }

        void BarCode_BarCodeEvent(BarCodeHook.BarCodes barCode)
        {
            ShowInfo(barCode);
        }
  
        private void LoadHandler_OnLoadEnd(object sender, Chromium.Event.CfxOnLoadEndEventArgs e)
        {
            BarCode.Start(); // 启动条码枪监听
        }

        private void FrameMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            BarCode.Stop();
        }
    }
}
 

