using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAsyncExtension.Test
{
    [TestFixture]
    public sealed class TestCase
    {
        private Form testForm;
        private Button testControl;
        private Thread testThread;

        [TestFixtureSetUp]
        public void SetUp()
        {
            if (this.testForm != null)
            {
                try { this.testForm.Dispose(); }
                catch { }

                this.testForm = null;
            }

            this.testThread = new Thread(this.TestThread);
            this.testThread.Start();
        }

        private void TestThread()
        {
            Application.OleRequired();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            this.testForm = new Form()
            {
                Text = DateTime.UtcNow.ToString()
            };
            this.testControl = new Button()
            {
                Text = "Click Here!"
            };
            Application.Run(this.testForm);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            if (this.testForm != null)
            {
                try { this.testForm.Dispose(); }
                catch { }

                this.testForm = null;
            }

            if (this.testThread != null)
            {
                try { this.testThread.Abort(); }
                catch { }

                this.testThread = null;
            }
        }

        [Test]
        public async Task ShowHideTest()
        {
            bool visibility;

            await this.testForm.ShowAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.True);

            await this.testForm.SetTextAsync("Please wait a moment.");
            Thread.Sleep(TimeSpan.FromSeconds(3d));

            await this.testForm.HideAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.False);
        }

        [Test]
        public async Task GetSetTitleTest()
        {
            string temp;
            bool visibility;

            await this.testForm.ShowAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.True);

            await testForm.SetTextAsync("Three!");
            temp = await testForm.GetTextAsync();
            Assert.That(temp, Is.EqualTo("Three!"));
            Thread.Sleep(TimeSpan.FromSeconds(1d));

            await testForm.SetTextAsync("Two!");
            temp = await testForm.GetTextAsync();
            Assert.That(temp, Is.EqualTo("Two!"));
            Thread.Sleep(TimeSpan.FromSeconds(1d));

            await testForm.SetTextAsync("One!");
            temp = await testForm.GetTextAsync();
            Assert.That(temp, Is.EqualTo("One!"));
            Thread.Sleep(TimeSpan.FromSeconds(1d));

            await this.testForm.HideAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.False);
        }

        [Test]
        public async Task ControlAddRemoveTest()
        {
            bool visibility;

            await this.testForm.ShowAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.True);

            Thread.Sleep(TimeSpan.FromSeconds(1d));
            await this.testForm.AddControlAsync(this.testControl);
            Thread.Sleep(TimeSpan.FromSeconds(1d));
            await this.testForm.RemoveControlAsync(this.testControl);
            Thread.Sleep(TimeSpan.FromSeconds(1d));

            await this.testForm.HideAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.False);
        }
    }
}
