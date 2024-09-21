using XsdTool.Presentation.Core;

namespace XsdTool
{
    public partial class AppShell
    {
        public AppShell(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            this.AddShellItems(serviceProvider);
        }

        private void AddShellItems(IServiceProvider serviceProvider)
        {
            var mainPageFactory = serviceProvider.GetRequiredService<IMainPageFactory>();
            this.Items.Add(mainPageFactory.Create());
        }
    }
}
