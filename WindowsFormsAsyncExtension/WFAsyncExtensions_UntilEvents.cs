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
        public static Task<EventArgs> UntilBackColorChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.BackColorChanged -= handler;
            };
            control.BackColorChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilBackgroundImageChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.BackgroundImageChanged -= handler;
            };
            control.BackgroundImageChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilBackgroundImageLayoutChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.BackgroundImageLayoutChanged -= handler;
            };
            control.BackgroundImageLayoutChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilBindingContextChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.BindingContextChanged -= handler;
            };
            control.BindingContextChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilCausesValidationChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.CausesValidationChanged -= handler;
            };
            control.CausesValidationChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilChangeUICues(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            UICuesEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ChangeUICues -= handler;
            };
            control.ChangeUICues += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilClick(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Click -= handler;
            };
            control.Click += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilClientSizeChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ClientSizeChanged -= handler;
            };
            control.ClientSizeChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilContextMenuChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ContextMenuChanged -= handler;
            };
            control.ContextMenuChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilContextMenuStripChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ContextMenuStripChanged -= handler;
            };
            control.ContextMenuStripChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilControlAdded(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            ControlEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ControlAdded -= handler;
            };
            control.ControlAdded += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilControlRemoved(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            ControlEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ControlRemoved -= handler;
            };
            control.ControlRemoved += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilCursorChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.CursorChanged -= handler;
            };
            control.CursorChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilDisposed(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Disposed -= handler;
            };
            control.Disposed += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilDockChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.DockChanged -= handler;
            };
            control.DockChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilDoubleClick(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.DoubleClick -= handler;
            };
            control.DoubleClick += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilDragDrop(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            DragEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.DragDrop -= handler;
            };
            control.DragDrop += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilDragEnter(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            DragEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.DragEnter -= handler;
            };
            control.DragEnter += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilDragLeave(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.DragLeave -= handler;
            };
            control.DragLeave += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilDragOver(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            DragEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.DragOver -= handler;
            };
            control.DragOver += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilEnabledChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.EnabledChanged -= handler;
            };
            control.EnabledChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilEnter(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Enter -= handler;
            };
            control.Enter += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilFontChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.FontChanged -= handler;
            };
            control.FontChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilForeColorChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ForeColorChanged -= handler;
            };
            control.ForeColorChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilGiveFeedback(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            GiveFeedbackEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.GiveFeedback -= handler;
            };
            control.GiveFeedback += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilGotFocus(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.GotFocus -= handler;
            };
            control.GotFocus += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilHandleCreated(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.HandleCreated -= handler;
            };
            control.HandleCreated += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilHandleDestroyed(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.HandleDestroyed -= handler;
            };
            control.HandleDestroyed += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilHelpRequested(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            HelpEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.HelpRequested -= handler;
            };
            control.HelpRequested += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilImeModeChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ImeModeChanged -= handler;
            };
            control.ImeModeChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilInvalidated(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            InvalidateEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Invalidated -= handler;
            };
            control.Invalidated += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilKeyDown(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            KeyEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.KeyDown -= handler;
            };
            control.KeyDown += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilKeyPress(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            KeyPressEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.KeyPress -= handler;
            };
            control.KeyPress += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilKeyUp(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            KeyEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.KeyUp -= handler;
            };
            control.KeyUp += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilLayout(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            LayoutEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Layout -= handler;
            };
            control.Layout += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilLeave(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Leave -= handler;
            };
            control.Leave += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilLocationChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.LocationChanged -= handler;
            };
            control.LocationChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilLostFocus(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.LostFocus -= handler;
            };
            control.LostFocus += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMarginChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MarginChanged -= handler;
            };
            control.MarginChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMouseCaptureChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MouseCaptureChanged -= handler;
            };
            control.MouseCaptureChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMouseClick(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            MouseEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MouseClick -= handler;
            };
            control.MouseClick += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMouseDoubleClick(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            MouseEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MouseDoubleClick -= handler;
            };
            control.MouseDoubleClick += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMouseDown(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            MouseEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MouseDown -= handler;
            };
            control.MouseDown += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMouseEnter(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MouseEnter -= handler;
            };
            control.MouseEnter += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMouseHover(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MouseHover -= handler;
            };
            control.MouseHover += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMouseLeave(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MouseLeave -= handler;
            };
            control.MouseLeave += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMouseMove(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            MouseEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MouseMove -= handler;
            };
            control.MouseMove += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMouseUp(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            MouseEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MouseUp -= handler;
            };
            control.MouseUp += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMouseWheel(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            MouseEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MouseWheel -= handler;
            };
            control.MouseWheel += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMove(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Move -= handler;
            };
            control.Move += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilPaddingChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.PaddingChanged -= handler;
            };
            control.PaddingChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilPaint(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            PaintEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Paint -= handler;
            };
            control.Paint += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilParentChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ParentChanged -= handler;
            };
            control.ParentChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilPreviewKeyDown(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            PreviewKeyDownEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.PreviewKeyDown -= handler;
            };
            control.PreviewKeyDown += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilQueryAccessibilityHelp(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            QueryAccessibilityHelpEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.QueryAccessibilityHelp -= handler;
            };
            control.QueryAccessibilityHelp += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilQueryContinueDrag(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            QueryContinueDragEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.QueryContinueDrag -= handler;
            };
            control.QueryContinueDrag += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilRegionChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.RegionChanged -= handler;
            };
            control.RegionChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilResize(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Resize -= handler;
            };
            control.Resize += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilRightToLeftChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.RightToLeftChanged -= handler;
            };
            control.RightToLeftChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilSizeChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.SizeChanged -= handler;
            };
            control.SizeChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilStyleChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.StyleChanged -= handler;
            };
            control.StyleChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilSystemColorsChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.SystemColorsChanged -= handler;
            };
            control.SystemColorsChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilTabIndexChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.TabIndexChanged -= handler;
            };
            control.TabIndexChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilTabStopChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.TabStopChanged -= handler;
            };
            control.TabStopChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilTextChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.TextChanged -= handler;
            };
            control.TextChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilValidated(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Validated -= handler;
            };
            control.Validated += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilValidating(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            CancelEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Validating -= handler;
            };
            control.Validating += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilVisibleChanged(this Control control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.VisibleChanged -= handler;
            };
            control.VisibleChanged += handler;
            return tcs.Task;
        }
    }

    partial class WFAsyncExtensions
    {
        public static Task<EventArgs> UntilCanGoBackChanged(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.CanGoBackChanged -= handler;
            };
            control.CanGoBackChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilCanGoForwardChanged(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.CanGoForwardChanged -= handler;
            };
            control.CanGoForwardChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilDocumentCompleted(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            WebBrowserDocumentCompletedEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.DocumentCompleted -= handler;
            };
            control.DocumentCompleted += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilDocumentTitleChanged(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.DocumentTitleChanged -= handler;
            };
            control.DocumentTitleChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilEncryptionLevelChanged(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.EncryptionLevelChanged -= handler;
            };
            control.EncryptionLevelChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilFileDownload(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.FileDownload -= handler;
            };
            control.FileDownload += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilNavigated(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            WebBrowserNavigatedEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Navigated -= handler;
            };
            control.Navigated += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilNavigating(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            WebBrowserNavigatingEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Navigating -= handler;
            };
            control.Navigating += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilNewWindow(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            CancelEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.NewWindow -= handler;
            };
            control.NewWindow += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilProgressChanged(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            WebBrowserProgressChangedEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ProgressChanged -= handler;
            };
            control.ProgressChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilStatusTextChanged(this WebBrowser control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.StatusTextChanged -= handler;
            };
            control.StatusTextChanged += handler;
            return tcs.Task;
        }
    }

    partial class WFAsyncExtensions
    {
        public static Task<EventArgs> UntilActivated(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Activated -= handler;
            };
            control.Activated += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilAutoSizeChanged(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.AutoSizeChanged -= handler;
            };
            control.AutoSizeChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilAutoValidateChanged(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.AutoValidateChanged -= handler;
            };
            control.AutoValidateChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilClosed(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Closed -= handler;
            };
            control.Closed += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilClosing(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            CancelEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Closing -= handler;
            };
            control.Closing += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilDeactivate(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Deactivate -= handler;
            };
            control.Deactivate += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilFormClosed(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            FormClosedEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.FormClosed -= handler;
            };
            control.FormClosed += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilFormClosing(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            FormClosingEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.FormClosing -= handler;
            };
            control.FormClosing += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilHelpButtonClicked(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            CancelEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.HelpButtonClicked -= handler;
            };
            control.HelpButtonClicked += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilInputLanguageChanged(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            InputLanguageChangedEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.InputLanguageChanged -= handler;
            };
            control.InputLanguageChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilInputLanguageChanging(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            InputLanguageChangingEventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.InputLanguageChanging -= handler;
            };
            control.InputLanguageChanging += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilLoad(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Load -= handler;
            };
            control.Load += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMarginChanged(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MarginChanged -= handler;
            };
            control.MarginChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMaximumSizeChanged(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MaximumSizeChanged -= handler;
            };
            control.MaximumSizeChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMdiChildActivate(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MdiChildActivate -= handler;
            };
            control.MdiChildActivate += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMenuComplete(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MenuComplete -= handler;
            };
            control.MenuComplete += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMenuStart(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MenuStart -= handler;
            };
            control.MenuStart += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilMinimumSizeChanged(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.MinimumSizeChanged -= handler;
            };
            control.MinimumSizeChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilResizeBegin(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ResizeBegin -= handler;
            };
            control.ResizeBegin += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilResizeEnd(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.ResizeEnd -= handler;
            };
            control.ResizeEnd += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilRightToLeftLayoutChanged(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.RightToLeftLayoutChanged -= handler;
            };
            control.RightToLeftLayoutChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilShown(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.Shown -= handler;
            };
            control.Shown += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilTabStopChanged(this Form control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.TabStopChanged -= handler;
            };
            control.TabStopChanged += handler;
            return tcs.Task;
        }
    }

    partial class WFAsyncExtensions
    {
        public static Task<EventArgs> UntilAppearanceChanged(this CheckBox control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.AppearanceChanged -= handler;
            };
            control.AppearanceChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilCheckedChanged(this CheckBox control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.CheckedChanged -= handler;
            };
            control.CheckedChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilCheckStateChanged(this CheckBox control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.CheckStateChanged -= handler;
            };
            control.CheckStateChanged += handler;
            return tcs.Task;
        }
    }

    partial class WFAsyncExtensions
    {
        public static Task<EventArgs> UntilAppearanceChanged(this RadioButton control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.AppearanceChanged -= handler;
            };
            control.AppearanceChanged += handler;
            return tcs.Task;
        }

        public static Task<EventArgs> UntilCheckedChanged(this RadioButton control)
        {
            var tcs = new TaskCompletionSource<EventArgs>();
            EventHandler handler = (s, e) => { };
            handler = (s, e) =>
            {
                tcs.TrySetResult(e);
                control.CheckedChanged -= handler;
            };
            control.CheckedChanged += handler;
            return tcs.Task;
        }
    }

    // todo: listbox, combobox
}
