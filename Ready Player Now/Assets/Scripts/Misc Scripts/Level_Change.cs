using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Make sure to add this, or you can't use SceneManager
using UnityEngine.SceneManagement;


public class Level_Change : MonoBehaviour
{
    public int levelIndex = 0;
    public DialogueTrigger ss;

    public bool transition = false;
    //public bool ready = false;
    //IE if you want the fade to black to work
    public bool useGameSceneManager = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        //other.name should equal the root of your Player object
        if (other.tag == "Player")
        {
            //The scene number to load (in File->Build Settings)
            if (useGameSceneManager)
            {
                //GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
                GameObject.FindGameObjectWithTag("SceneManager").GetComponent<GameSceneManager>().LoadScene(levelIndex);
                
            }
            else if (transition || ss.ready)
            {
                //GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().StopMusic();
                SceneManager.LoadScene(levelIndex);
            }
            else {
                //Debug.Log("I AM HERE CHRIS LOOK AT ME");
            }
        }
    }
}