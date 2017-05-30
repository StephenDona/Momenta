using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour {



    public GameObject Ring;
    public int BoxSelection = 0;
    public bool YellowDone;
    public bool BlueDone;
    public bool GreenDone;
    public bool RedDone;

    bool LevelNotLoaded = true;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        GetNumKeys();
        GetScrollWheel();
        RepositionDisplayRing();

        if (RedDone && BlueDone && YellowDone && GreenDone && LevelNotLoaded)
        {
            SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
            LevelNotLoaded = false;
        }

    }

    void RepositionDisplayRing()
    {
        if (BoxSelection == 0)
        {
            Ring.GetComponent<RectTransform>().anchoredPosition = new Vector3(-150.0f, -210.0f, 0.0f);

        }

        if (BoxSelection == 1)
        {
            Ring.GetComponent<RectTransform>().anchoredPosition = new Vector3(-51.0f, -210.0f, 0.0f);

        }

        if (BoxSelection == 2)
        {
            Ring.GetComponent<RectTransform>().anchoredPosition = new Vector3(50.0f, -210.0f, 0.0f);

        }
        if (BoxSelection == 3)
        {
            Ring.GetComponent<RectTransform>().anchoredPosition = new Vector3(150.0f, -210.0f, 0.0f);

        }

    }

    void GetNumKeys()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            BoxSelection = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            BoxSelection = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            BoxSelection = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            BoxSelection = 3;
        }
    }

    void GetScrollWheel()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0.1)
        {
            BoxSelection--;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < -0.1)
        {
            BoxSelection++;
        }

        if(BoxSelection > 3)
        {
            BoxSelection = 0;
        }

        if (BoxSelection < 0)
        {
            BoxSelection = 3;
        }
    }
}
