using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{

    public string BoxColour;
    public GameObject Respawn;
    public bool Death;

    public GameObject gameScriptObj;
    GameScript gameScript;

    // Use this for initialization
    void Start()
    {
        gameScript = gameScriptObj.GetComponent<GameScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        if(BoxColour == "Red" && other.gameObject.tag == "RedBox")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            gameScript.RedDone = true;

        }

        if (BoxColour == "Blue" && other.gameObject.tag == "BlueBox")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            gameScript.BlueDone = true;
        }

        if (BoxColour == "Green" && other.gameObject.tag == "GreenBox")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            gameScript.GreenDone = true;
        }

        if (BoxColour == "Yellow" && other.gameObject.tag == "YellowBox")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            gameScript.YellowDone = true;
        }


        if(Death)
        {
            if (other.gameObject.tag == "Player")
            {
                other.gameObject.transform.position = Respawn.transform.position;
            }
            else
            {
                Destroy(other.gameObject);
            }
        }


    }
}
