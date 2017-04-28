using NUnit.Framework;
using System.Linq;
using Xamarin.UITest;

namespace CiCdApp.Test
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        private IApp app;
        private Platform platform;

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
        public void AppLaunches()
        {
            // Not a real test, just here to have some first reference
            app.Screenshot("First screen.");
        }

        [Test]
        public void Press_Good_Button_And_Pass_Hooray()
        {
            // Arrange
            // Nothing to arrange for this test

            // Act
            app.Tap(e => e.Marked("GoodButtonForTextEntry"));
            app.Screenshot("Test TADA! entered");

            // Assert
            Assert.AreEqual("TADA!", app.Query(e => e.Marked("TextEntry")).First().Text);
        }

        [Test]
        public void Press_Bad_Button_And_Fail_Boo()
        {
            // Arrange
            app.ClearText("TextEntry");

            // Act
            app.Tap(e => e.Marked("BadButtonForTextEntry"));
            app.Screenshot("Text should not be entered");

            Assert.AreEqual("TADA!", app.Query(e => e.Marked("TextEntry")).First().Text);
        }
    }
}