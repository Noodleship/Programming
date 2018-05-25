using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Moving_test : MonoBehaviour
    {
        public float speed = 20f; // Units to travel per second
        public float rotationSpeed = 360; // Amount of rotation per second

        private Rigidbody2D rigid; // Reference to attatched Rigidbody2D

        // Use this for initialization
        void Start()
        {
            // Grab reference to rigidbody2D component
            // NOTE: It gets this from GameObject this script is attatched to
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            // Check if A key is pressed
            if (Input.GetKey(KeyCode.A))
            {
                //Rotate left
                transform.Rotate(Vector3.forward, rotationSpeed);
            }

            // Check if D key is pressed
           
            if (Input.GetKey(KeyCode.D))
            {
                // Rotate right
                transform.Rotate(Vector3.back, rotationSpeed);
            }

            // Check if W key is pressed
            if (Input.GetKey(KeyCode.W))
            {
                // Move in facing direction
                rigid.AddForce(transform.up * speed);
            }
        }
    }
}