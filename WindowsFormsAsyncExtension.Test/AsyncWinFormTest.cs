using NUnit.Framework;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAsyncExtension.Test
{
    [TestFixture]
    public sealed class AsyncWinFormTest
    {
        [Test]
        public async void AsyncTest()
        {
            ExampleForm form = null;
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
            var thread = FormActivator.StartApp<ExampleForm>(() =>
                {
                    Application.OleRequired();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    form = new ExampleForm();
                    tcs.TrySetResult(true);

                    form.buttonA.OnClick(async (e) =>
                    {
                        await form.ShowMessageBoxAsync(
                            String.Format("hello! you just clicked {0}!",
                            await form.buttonA.GetTextAsync()));
                    });
                    form.buttonB.OnClick(async (e) =>
                    {
                        await form.ShowMessageBoxAsync(
                            String.Format("hello! you just clicked {0}!",
                            await form.buttonB.GetTextAsync()));
                    });
                    form.buttonC.OnClick(async (e) =>
                    {
                        await form.ShowMessageBoxAsync(
                            String.Format("hello! you just clicked {0}!",
                            await form.buttonC.GetTextAsync()));
                    });

                    return form;
                });
            await tcs.Task;
            await form.buttonC.UntilClick();
        }
    }
}
