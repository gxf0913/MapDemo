using System.Collections;
using System.Collections.Generic;
using FairyGUI;
using UI.MapDemo;
using UnityEngine;

namespace Demo
{
  public class Game : MonoBehaviour
  {
    public UI_map _map { get; set; }
    public UI_initial_hud _initial_hud { get; set; }
    
    public static Game Instance;
    private void Awake()
    {
      if (Instance == null)
      {
        Instance = this;
      }
      InitUI();
      InitHUD();
    }
    
    private void InitHUD()
    {
      _initial_hud = CreateUi<UI_initial_hud>();
      _initial_hud.open_map_btn.onClick.Set(() =>
      {
        // 打开背包
        if (_map == null)
        {
          _map = CreateUi<UI_map>();
          var MapView = _map.displayObject.gameObject.AddComponent<MapView>();
          MapView.InitUi(_map); 
        }else{GRoot.inst.AddChild(_map);}

      });
    }
    
    private T CreateUi<T>() where T : GComponent
    {
      if (typeof(T).GetMethod("CreateInstance")?.Invoke(null, null) is GComponent component)
      {
        component.SetSize(GRoot.inst.width, GRoot.inst.height);
        component.AddRelation(GRoot.inst, RelationType.Size);
        GRoot.inst.AddChild(component);
        return (T) component;
      }

      return null;
    }
    
    private void InitUI()
    {
      GRoot.inst.SetContentScaleFactor(2436, 1125, UIContentScaler.ScreenMatchMode.MatchWidthOrHeight);
      UIPackage.AddPackage("UI/MapDemo");
      MapDemoBinder.BindAll();
    }
  }
}
