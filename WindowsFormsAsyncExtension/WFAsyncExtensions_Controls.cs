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

        private static readonly Func<System.Windows.Forms.Control, System.Type, System.Windows.Forms.Control> addNewControlInternal = (x, v) => { Control c = Activator.CreateInstance(v) as Control; x.Controls.Add(c); return c; };
        public static Control AddNewControl(this System.Windows.Forms.Control target, System.Type value)
        {
            if (target == null)
                throw new ArgumentNullException("target");
            if (value == null ||
                !value.IsSubclassOf(typeof(System.Windows.Forms.Control)))
                throw new ArgumentException("Selected type is not a Windows Forms control type.", "value");
            if (target.InvokeRequired)
                return target.Invoke(addNewControlInternal, target, value) as Control;
            else
                return addNewControlInternal.Invoke(target, value) as Control;
        }
        public static T AddNewControl<T>(this System.Windows.Forms.Control target)
            where T : System.Windows.Forms.Control
        {
            return AddNewControl(target, typeof(T)) as T;
        }
        private static readonly Func<System.Windows.Forms.Control, System.Type, System.Windows.Forms.Control> addNewControlCallback = AddNewControl;
        public static IAsyncResult BeginAddNewControl(this System.Windows.Forms.Control target, System.Type value, AsyncCallback callback, object state)
        {
            return addNewControlCallback.BeginInvoke(target, value, callback, state);
        }
        public static IAsyncResult BeginAddNewControl<T>(this System.Windows.Forms.Control target, AsyncCallback callback, object state)
        {
            return BeginAddNewControl(target, typeof(T), callback, state);
        }
        public static Control EndAddNewControl(this System.Windows.Forms.Control target, IAsyncResult result)
        {
            return EndAddNewControl(result);
        }
        public static Control EndAddNewControl(IAsyncResult result)
        {
            return addNewControlCallback.EndInvoke(result);
        }
        public static T EndAddNewControl<T>(this System.Windows.Forms.Control target, IAsyncResult result)
            where T : System.Windows.Forms.Control
        {
            return EndAddNewControl<T>(result);
        }
        public static T EndAddNewControl<T>(IAsyncResult result)
            where T : System.Windows.Forms.Control
        {
            return addNewControlCallback.EndInvoke(result) as T;
        }
        public static Task<System.Windows.Forms.Control> AddNewControlAsync(this System.Windows.Forms.Control target, System.Type value)
        {
            return Task<System.Windows.Forms.Control>.Factory.FromAsync<System.Windows.Forms.Control, System.Type>(
                BeginAddNewControl,
                EndAddNewControl,
                target, value, null);
        }
        public static Task<T> AddNewControlAsync<T>(this System.Windows.Forms.Control target)
            where T : System.Windows.Forms.Control
        {
            return Task<T>.Factory.FromAsync<System.Windows.Forms.Control>(
                BeginAddNewControl<T>,
                EndAddNewControl<T>,
                target, null);
        }


        private static readonly Func<System.Windows.Forms.Control, System.Type, System.Windows.Forms.Control> createNewControlInternal = (x, v) => { Control c = Activator.CreateInstance(v) as Control; return c; };
        public static Control CreateNewControl(this System.Windows.Forms.Control target, System.Type value)
        {
            if (target == null)
                throw new ArgumentNullException("target");
            if (value == null ||
                !value.IsSubclassOf(typeof(System.Windows.Forms.Control)))
                throw new ArgumentException("Selected type is not a Windows Forms control type.", "value");
            if (target.InvokeRequired)
                return target.Invoke(createNewControlInternal, target, value) as Control;
            else
                return createNewControlInternal.Invoke(target, value) as Control;
        }
        public static T CreateNewControl<T>(this System.Windows.Forms.Control target)
            where T : System.Windows.Forms.Control
        {
            return CreateNewControl(target, typeof(T)) as T;
        }
        private static readonly Func<System.Windows.Forms.Control, System.Type, System.Windows.Forms.Control> createNewControlCallback = CreateNewControl;
        public static IAsyncResult BeginCreateNewControl(this System.Windows.Forms.Control target, System.Type value, AsyncCallback callback, object state)
        {
            return createNewControlCallback.BeginInvoke(target, value, callback, state);
        }
        public static IAsyncResult BeginCreateNewControl<T>(this System.Windows.Forms.Control target, AsyncCallback callback, object state)
        {
            return BeginCreateNewControl(target, typeof(T), callback, state);
        }
        public static Control EndCreateNewControl(this System.Windows.Forms.Control target, IAsyncResult result)
        {
            return EndCreateNewControl(result);
        }
        public static Control EndCreateNewControl(IAsyncResult result)
        {
            return createNewControlCallback.EndInvoke(result);
        }
        public static T EndCreateNewControl<T>(this System.Windows.Forms.Control target, IAsyncResult result)
            where T : System.Windows.Forms.Control
        {
            return EndCreateNewControl<T>(result);
        }
        public static T EndCreateNewControl<T>(IAsyncResult result)
            where T : System.Windows.Forms.Control
        {
            return createNewControlCallback.EndInvoke(result) as T;
        }
        public static Task<System.Windows.Forms.Control> CreateNewControlAsync(this System.Windows.Forms.Control target, System.Type value)
        {
            return Task<System.Windows.Forms.Control>.Factory.FromAsync<System.Windows.Forms.Control, System.Type>(
                BeginCreateNewControl,
                EndCreateNewControl,
                target, value, null);
        }
        public static Task<T> CreateNewControlAsync<T>(this System.Windows.Forms.Control target)
            where T : System.Windows.Forms.Control
        {
            return Task<T>.Factory.FromAsync<System.Windows.Forms.Control>(
                BeginCreateNewControl<T>,
                EndCreateNewControl<T>,
                target, null);
        }
    }
}
