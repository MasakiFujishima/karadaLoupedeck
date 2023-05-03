namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Show_Viewer : PluginDynamicCommand
    {
        public Show_Viewer()
        : base(displayName: "Show Viewer", description: "Show Viewer", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Show Viewer", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad9, ModifierKey.Ctrl);
        }
    }
}
