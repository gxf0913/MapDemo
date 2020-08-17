using System.Collections;
using System.Collections.Generic;
using FairyGUI;
using UI.MapDemo;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace Demo
{
    public class MapView : MonoBehaviour
    {
        private UI_map _ui { get; set; }

        public void InitUi(UI_map _map)
        {
            this._ui = _map;
            _ui.map.close_btn.onClick.Set(CloseMap);
            EnterRoom();
        }

        private void EnterRoom()
        {
            _ui.map.floor1_corridor_btn.onClick.Set((() =>
            {
                Debug.Log("进入一楼走廊");
                CloseMap();
            }));
            _ui.map.floor1_main_transformer_room_1.onClick.Set((() => 
            { 
                Debug.Log("进入一楼主变室1");
                CloseMap();
            }));
            _ui.map.floor1_main_transformer_room_2.onClick.Set((() => 
            { 
                Debug.Log("进入一楼主变室2");
                CloseMap();
            }));
            _ui.map.floor1_tool_room.onClick.Set((() =>
            { 
                Debug.Log("进入一楼工具间");
                CloseMap();
            }));
            _ui.map.floor2_capacitor_room_1.onClick.Set((() => 
            { 
                Debug.Log("进入二楼电容室1");
                CloseMap();
            }));
            _ui.map.floor2_capacitor_room_2.onClick.Set((() => 
            { 
                Debug.Log("进入二楼电容室2");
                CloseMap();
            }));
            _ui.map.floor2_capacitor_room_3.onClick.Set((() => 
            { 
                Debug.Log("进入二楼电容室3");
                CloseMap();
            }));
            _ui.map.floor2_corridor_btn.onClick.Set((() => 
            { 
                Debug.Log("进入二楼走廊");
                CloseMap();
            }));
            _ui.map.floor1_10KV_switch_room.onClick.Set((() =>
            {
                Debug.Log("进入一楼10KV开关室");
                CloseMap();
            }));
            _ui.map.floor1_110KV_switch_room.onClick.Set((() => 
            {
                Debug.Log("进入一楼110KV开关室");
                CloseMap();
            }));
        }

        private void CloseMap()
        {
            GRoot.inst.RemoveChild(_ui);
        }
        
        /*SteamVR_TrackedObject controller;
        SteamVR_Action_Boolean GrabAction;
        void Start()
        {
            controller = ...;
        }

        void Update() 
        {
            Vector3 pos = controller.transform.position;
            Vector3 dir = controller.transform.forward;

            bool triggerDown = GrabAction.GetStateDown(SteamVR_Input_Sources.Any);

            RaycastHit rh;
            if (Physics.Raycast(pos, dir, out rh))
            {
                Stage.inst.SetCustomInput(rh.point, triggerDown);
            }
        }*/
        
    }
}
