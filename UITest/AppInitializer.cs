using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile(@"C:\UITEST\com.companyname.appcenterxamrain_test_example.apk")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}