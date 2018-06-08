using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assessment1
{
    public class Collect : MonoBehaviour
    {
     
        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Collectable")//for when the ball touches a block
            {
                Destroy(other.gameObject); // destroys block

            }
        }
    }
}