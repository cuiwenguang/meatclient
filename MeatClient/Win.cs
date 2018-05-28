using NetDimension.NanUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatClient
{
    class Win
    {

        public static void Register(WinFormium form)
        {
            var window = form.GlobalObject.AddObject("win");
            // 刷新方法
            var refresh = window.AddFunction("refresh");
            refresh.Execute += (func, args) =>
            {
                form.Browser.ReloadIgnoreCache();
            };

            // 弹出框
            var alert = window.AddFunction("messageBox");
            alert.Execute += (func, args) =>
            {
                var stringArgument = args.Arguments.FirstOrDefault(p => p.IsString);

                if (stringArgument != null)
                {
                    MessageBox.Show(form, stringArgument.StringValue, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }
    }
}
