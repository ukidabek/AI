using UnityEngine;
using UnityEngine.Events;

namespace BaseGameLogic.AI.Events
{
    [System.Serializable]
    public class TargetChangedUnityEvent : UnityEvent<GameObject> {}
}
