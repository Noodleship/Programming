using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;// allows the text for the score to be used
using UnityEngine;


namespace Assessment1
{
    public class Collect : MonoBehaviour
    {
        //static int
        public static int counter = 0;// makes sure the score starts at 0
        public Text counterText; // display of text onscreen\

        void Start()
        {
            counter = 0;//resets score counter when scene resets
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Collectable")//for when the ball touches a block
            {
                Destroy(other.gameObject); // destroys block
                counter++;//increases score by 1 when ball hits a collectable

                Debug.Log(counter); // prints countervalue to console window
                counterText.text = "Score: " + counter.ToString(); // the score gets turned into text for the score text display
            }
        }
    }
}