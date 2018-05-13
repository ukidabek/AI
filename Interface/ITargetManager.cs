using BaseGameLogic.AI.Events;
using UnityEngine;

public interface ITargetManager
{
    void TargetDetected(GameObject target);

    TargetChangedUnityEvent TargetChanged { get; }
    GameObject Target { get; }
   }
