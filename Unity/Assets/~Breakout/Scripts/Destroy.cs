using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;// allows the text for the score to be used
using UnityEngine.SceneManagement;
using UnityEngine;

namespace Breakout
{
    public class Destroy : MonoBehaviour
    {
        //static int
        public static int counter = 0;// makes sure the score starts at 0
        public Text counterText; // display of text onscreen\
        
        void Start()
        {
            counter = 0;//resets score counter when scene resets
        }
        void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.tag == "Blocks")//for when the ball touches a block
            {
                Destroy(coll.gameObject); // destroys block
                counter++;//increases score by 1 when ball hits a block

                Debug.Log(counter); // prints countervalue to console window
                counterText.text = counter.ToString(); // the score gets turned into text for the score text display              
            }

            if (coll.gameObject.tag == "SpecialBlocks")
            {
                Destroy(coll.gameObject);
                counter += 5;

                Debug.Log(counter);
                counterText.text = counter.ToString();
            }

                if (coll.gameObject.tag == "Death")
            {
                SceneManager.LoadScene(3);//resets scene when ball hits deathzone
            }
        }
    }
}