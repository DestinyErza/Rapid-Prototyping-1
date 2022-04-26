using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    
   // protected static TargetManager _TM { get { return TargetManager.instance; } }
    protected static UIManager _UI { get { return UIManager.instance; } }
    protected static PlayerController _PC { get { return PlayerController.instance; } }
    protected static PlayerController1 _PC1 { get { return PlayerController1.instance; } }
    protected static PlayerController3 _PC3 { get { return PlayerController3.instance; } }
    protected static OpenInventory _OI { get { return OpenInventory.instance; } }
    protected static TimerScoring _TS { get { return TimerScoring.instance; } }

   // protected static PlotManager _PM { get { return PlotManager.instance; } }
    // protected static Score _S { get { return Score.instance; } }
}
