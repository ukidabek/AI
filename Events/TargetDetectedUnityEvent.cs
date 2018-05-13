using UnityEngine;
using UnityEngine.Events;

namespace BaseGameLogic.AI.Events
{
    [System.Serializable]
    public class TargetDetectedUnityEvent : UnityEvent<GameObject> {}
}