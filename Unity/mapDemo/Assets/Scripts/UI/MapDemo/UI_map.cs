/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI.MapDemo
{
    public partial class UI_map : GComponent
    {
        public UI_map_panel map;
        public const string URL = "ui://rq5i0m0rigrr7";

        public static UI_map CreateInstance()
        {
            return (UI_map)UIPackage.CreateObject("MapDemo", "map");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            map = (UI_map_panel)GetChildAt(0);
        }
    }
}