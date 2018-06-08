using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{
    public class Movement : MonoBehaviour
    {
        public float rotationSpeed;

        void Rotation()
        {
            // Rotate Right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }
        }      

        // Update is called once per frame
        void Update()
        {
            // Call 'Rotation()' function
            Rotation();
        }
    }
}