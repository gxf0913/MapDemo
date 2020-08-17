/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI.MapDemo
{
    public partial class UI_map_panel : GComponent
    {
        public GButton floor1_110KV_switch_room;
        public GButton floor1_10KV_switch_room;
        public GButton floor1_tool_room;
        public GButton floor1_main_transformer_room_1;
        public GButton floor1_main_transformer_room_2;
        public GButton floor2_capacitor_room_1;
        public GButton floor2_capacitor_room_2;
        public GButton floor2_capacitor_room_3;
        public GButton floor1_corridor_btn;
        public GButton floor2_corridor_btn;
        public GButton close_btn;
        public const string URL = "ui://rq5i0m0r7xjs0";

        public static UI_map_panel CreateInstance()
        {
            return (UI_map_panel)UIPackage.CreateObject("MapDemo", "map_panel");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            floor1_110KV_switch_room = (GButton)GetChildAt(1);
            floor1_10KV_switch_room = (GButton)GetChildAt(2);
            floor1_tool_room = (GButton)GetChildAt(3);
            floor1_main_transformer_room_1 = (GButton)GetChildAt(4);
            floor1_main_transformer_room_2 = (GButton)GetChildAt(5);
            floor2_capacitor_room_1 = (GButton)GetChildAt(6);
            floor2_capacitor_room_2 = (GButton)GetChildAt(7);
            floor2_capacitor_room_3 = (GButton)GetChildAt(8);
            floor1_corridor_btn = (GButton)GetChildAt(11);
            floor2_corridor_btn = (GButton)GetChildAt(12);
            close_btn = (GButton)GetChildAt(13);
        }
    }
}