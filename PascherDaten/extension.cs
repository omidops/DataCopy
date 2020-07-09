﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PascherDaten
{

    public static class extension
    {
        static public void UIThreadAsync(this Control control, Action code)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(code);
                return;
            }
            code.Invoke();
        }

        static public void UIThreadSync(this Control control, Action code)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(code);
                return;
            }
            code.Invoke();
        }
    }
}
