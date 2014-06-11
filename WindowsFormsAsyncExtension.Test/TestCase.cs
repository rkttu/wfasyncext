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

            this.testThread = FormActivator.StartApp<Form>(() =>
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
                return this.testForm;
            });
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
            await this.testForm.ActivateAsync();
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
            await this.testForm.ActivateAsync();
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
            await this.testForm.ActivateAsync();
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

        [Test]
        public async Task ControlAddRemoveTest2()
        {
            bool visibility;

            await this.testForm.ShowAsync();
            await this.testForm.ActivateAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.True);

            Thread.Sleep(TimeSpan.FromSeconds(1d));
            Button b = await this.testForm.AddNewControlAsync<Button>();
            b.Text = "Created by outer thread";
            b.AutoSize = true;
            Thread.Sleep(TimeSpan.FromSeconds(1d));
            await this.testForm.RemoveControlAsync(b);
            Thread.Sleep(TimeSpan.FromSeconds(1d));

            await this.testForm.HideAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.False);
        }

        [Test]
        public async Task ControlAddRemoveTest3()
        {
            bool visibility;

            await this.testForm.ShowAsync();
            await this.testForm.ActivateAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.True);

            Thread.Sleep(TimeSpan.FromSeconds(1d));
            Button b = await this.testForm.CreateNewControlAsync<Button>();
            b.Text = "Created by outer thread";
            b.AutoSize = true;
            await testForm.AddControlAsync(b);
            Thread.Sleep(TimeSpan.FromSeconds(1d));
            await this.testForm.RemoveControlAsync(b);
            Thread.Sleep(TimeSpan.FromSeconds(1d));

            await this.testForm.HideAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.False);
        }

        [Test]
        public async Task ControlAddRemoveTest4()
        {
            bool visibility;

            await this.testForm.ShowAsync();
            await this.testForm.ActivateAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.True);

            Thread.Sleep(TimeSpan.FromSeconds(1d));
            Button b = await this.testForm.CreateNewControlAsync<Button>();
            b.Text = "Created by outer thread";
            b.AutoSize = true;
            await testForm.AddControlAsync(b);
            Thread.Sleep(TimeSpan.FromSeconds(1d));
            await b.SetParentAsync(testForm);
            Thread.Sleep(TimeSpan.FromSeconds(1d));
            await b.SetParentAsync(null);
            Thread.Sleep(TimeSpan.FromSeconds(1d));

            await this.testForm.HideAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.False);
        }

        [Test]
        public async Task InvokeTest1()
        {
            bool visibility;

            await this.testForm.ShowAsync();
            await this.testForm.ActivateAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.True);

            await this.testForm.InvokeAsync(new Action(() =>
            {
                this.testForm.Text = "Hello from invokeAsync!";
            }));
            Thread.Sleep(TimeSpan.FromSeconds(3d));

            await this.testForm.HideAsync();
            visibility = await this.testForm.GetVisibleAsync();
            Assert.That(visibility, Is.False);
        }
    }
}
