using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        private void ButtonTest()
        {
            int btnCount = 3;
            string btnName = "button";
            for (int i = 1; i <= btnCount; i++) 
            {
                btnName = btnName+i.ToString();
                app.Tap(c => c.Marked(btnName));
                app.Screenshot(btnName);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
