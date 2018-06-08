using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

namespace Assessment1
{
    public class Goal : MonoBehaviour
    {
        public UnityEvent onTriggered;
        public bool isActive = false;

        void Update()
        {
            if(transform.childCount == 0)
            {
                isActive = true;
            }
        }

        // Fired off when another collider enters goal
        void OnTriggerEnter2D(Collider2D other)
        {
            // Detect if other collider is ball
            if (other.name == "Ball" && 
                isActive)
            {
                // Fire off our event (onTriggered)
                onTriggered.Invoke();
            }
        }
    }
}