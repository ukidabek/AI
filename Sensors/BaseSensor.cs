using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using BaseGameLogic.AI.Events;

namespace BaseGameLogic.AI.Sensors
{
    public abstract class BaseSensor : MonoBehaviour
    {
        [SerializeField] protected TargetDetectedUnityEvent targetDetected = new TargetDetectedUnityEvent();

        public virtual bool PositiveReading() { return false; }
    }
}