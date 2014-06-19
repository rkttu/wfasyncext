using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    partial class WFAsyncExtensions
    {
        public static Task OnClick(this Control control, Action<Task<EventArgs>> handler)
        {
            Action<Task<EventArgs>> eventHandler = (e) => { };
            return control.UntilClick().ContinueWith(eventHandler = (e) =>
            {
                Task
                    .Factory
                    .FromAsync(handler.BeginInvoke(e, null, null), handler.EndInvoke)
                    .ContinueWith((temp) => control.UntilClick().ContinueWith(eventHandler));
            });
        }
    }

    // todo: listbox, combobox
}
