using UnityEngine;

using System.Collections;
using System.Collections.Generic;

namespace BaseGameLogic.AI
{
    public class AIManager : MonoBehaviour
    {
        [SerializeField] private List<Transform> _targets = new List<Transform>();

        private void OnTriggerEnter(Collider other)
        {
            _targets.Add(other.transform);    
        }

        private void OnTriggerExit(Collider other)
        {
            _targets.Remove(other.transform);
        }
    }
}
