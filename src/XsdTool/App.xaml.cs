﻿namespace XsdTool
{
    public partial class App
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            MainPage = new AppShell(serviceProvider);
        }
    }
}
