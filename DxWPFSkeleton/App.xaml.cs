using DXWPFSkeleton.Util;
using DevExpress.Xpf.Core;
using DXWPFSkeleton.Common;
using System;
using System.IO;
using System.Windows;

namespace DXWPFSkeleton
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            CompatibilitySettings.UseLightweightThemes = true;
            ApplicationThemeHelper.ApplicationThemeName = LightweightTheme.Win11Light.Name;
        }
        protected override void OnStartup(StartupEventArgs e)
        {

            base.OnStartup(e);

            // Home
            DirectoryInfo di = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));

            DIRECTORY.HOME = di.Parent.FullName;

            // 초기화
            Logger.Instance.Initialize(DIRECTORY.HOME);

            Configuration.Load(DIRECTORY.HOME);
        }
    }
}
