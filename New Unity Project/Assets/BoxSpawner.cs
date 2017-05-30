using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour {

    public GameObject Bluebox;
    public GameObject Greenbox;
    public GameObject Yellowbox;
    public GameObject Redbox;
    public GameObject Bullet;

    public GameObject FirstPersonScript;
    public GameObject GameScriptObject;
    GameScript gameScript;

    // Use this for initialization
    void Start () {
        gameScript = GameScriptObject.GetComponent<GameScript>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SummonBox();
        }

        if (Input.GetMouseButtonDown(1))
        {
            DestroyBox();
        }

    }

    void SummonBox()
    {
        if (gameScript.BoxSelection == 0)
        {
            Instantiate(Bluebox, transform.position, Quaternion.identity);

        }

        if (gameScript.BoxSelection == 1)
        {
            Instantiate(Redbox, transform.position, Quaternion.identity);

        }

        if (gameScript.BoxSelection == 2)
        {
            Instantiate(Greenbox, transform.position, Quaternion.identity);

        }
        if (gameScript.BoxSelection == 3)
        {
            Instantiate(Yellowbox, transform.position, Quaternion.identity);

        }
    }

    void DestroyBox()
    {
        Instantiate(Bullet, FirstPersonScript.transform.position, FirstPersonScript.transform.rotation);
    }
}
