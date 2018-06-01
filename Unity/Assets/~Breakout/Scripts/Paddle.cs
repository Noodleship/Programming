using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class Paddle : MonoBehaviour
    {
        public float movementSpeed = 10;
        public Ball currentBall;
        public bool hasFired;//true or false state default starts false
        public Vector3[] directions =
        {
            new Vector2(-.5f, .5f),
            new Vector2( .5f, .5f)
        };
        // Use this for initialization
        void Start()
        {
            hasFired = false;//we start the game and havent fired the ball

            currentBall = GetComponentInChildren<Ball>();
        }

        void Fire()
        {
            currentBall.transform.SetParent(null);
            Vector3 randomDir = directions[Random.Range(0, directions.Length)];
            currentBall.Fire(randomDir);
            hasFired = true;//once we fire the ball we state that we have fired the ball
        }
        void CheckInput()
        {
            if(!hasFired)//can only fire ball if we havent already
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Fire();
                }
            }
            
        }

        void Movement()
        {
            float inputH = Input.GetAxis("Horizontal");
            Vector3 force = transform.right * inputH;
            force *= movementSpeed;
            force *= Time.deltaTime;
            transform.position += force;
        }
        // Update is called once per frame
        void Update()
        {
            CheckInput();
            Movement();
        }
    }
}