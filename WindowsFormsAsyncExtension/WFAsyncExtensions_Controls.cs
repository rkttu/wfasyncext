using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{
    partial class WFAsyncExtensions
    {
        private static readonly Action<System.Windows.Forms.Control, System.Windows.Forms.Control> addControlInternal = (x, v) => x.Controls.Add(v);
        public static void AddControl(this System.Windows.Forms.Control target, System.Windows.Forms.Control value)
        {
            if (target == null)
                throw new ArgumentNullException("target");
            if (target.InvokeRequired)
                target.Invoke(addControlInternal, target, value);
            else
                addControlInternal.Invoke(target, value);
        }
        private static readonly Action<System.Windows.Forms.Control, System.Windows.Forms.Control> addControlCallback = AddControl;
        public static IAsyncResult BeginAddControl(this System.Windows.Forms.Control target, System.Windows.Forms.Control value, AsyncCallback callback, object state)
        {
            return addControlCallback.BeginInvoke(target, value, callback, state);
        }
        public static void EndAddControl(this System.Windows.Forms.Control target, IAsyncResult result)
        {
            EndAddControl(result);
        }
        public static void EndAddControl(IAsyncResult result)
        {
            addControlCallback.EndInvoke(result);
        }
        public static Task AddControlAsync(this System.Windows.Forms.Control target, System.Windows.Forms.Control value)
        {
            return Task.Factory.FromAsync<System.Windows.Forms.Control, System.Windows.Forms.Control>(
                BeginAddControl,
                EndAddControl,
                target, value, null);
        }

        private static readonly Action<System.Windows.Forms.Control, System.Windows.Forms.Control> removeControlInternal = (x, v) => x.Controls.Remove(v);
        public static void RemoveControl(this System.Windows.Forms.Control target, System.Windows.Forms.Control value)
        {
            if (target == null)
                throw new ArgumentNullException("target");
            if (target.InvokeRequired)
                target.Invoke(removeControlInternal, target, value);
            else
                removeControlInternal.Invoke(target, value);
        }
        private static readonly Action<System.Windows.Forms.Control, System.Windows.Forms.Control> removeControlCallback = RemoveControl;
        public static IAsyncResult BeginRemoveControl(this System.Windows.Forms.Control target, System.Windows.Forms.Control value, AsyncCallback callback, object state)
        {
            return removeControlCallback.BeginInvoke(target, value, callback, state);
        }
        public static void EndRemoveControl(this System.Windows.Forms.Control target, IAsyncResult result)
        {
            EndRemoveControl(result);
        }
        public static void EndRemoveControl(IAsyncResult result)
        {
            removeControlCallback.EndInvoke(result);
        }
        public static Task RemoveControlAsync(this System.Windows.Forms.Control target, System.Windows.Forms.Control value)
        {
            return Task.Factory.FromAsync<System.Windows.Forms.Control, System.Windows.Forms.Control>(
                BeginRemoveControl,
                EndRemoveControl,
                target, value, null);
        }
    }
}
