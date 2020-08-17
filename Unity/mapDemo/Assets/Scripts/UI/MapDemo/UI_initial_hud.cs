/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI.MapDemo
{
    public partial class UI_initial_hud : GComponent
    {
        public GButton open_map_btn;
        public const string URL = "ui://rq5i0m0rjry88";

        public static UI_initial_hud CreateInstance()
        {
            return (UI_initial_hud)UIPackage.CreateObject("MapDemo", "initial_hud");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            open_map_btn = (GButton)GetChildAt(0);
        }
    }
}