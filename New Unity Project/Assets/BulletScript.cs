using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public GameObject Bluebox;
    public GameObject Greenbox;
    public GameObject Yellowbox;
    public GameObject Redbox;

    float TimeCreated;
    public float Lifetime;

    // Use this for initialization
    void Start () {
        TimeCreated = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * 50);

        if (Time.realtimeSinceStartup > TimeCreated + Lifetime)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "BlueBox" || other.gameObject.tag == "GreenBox" || other.gameObject.tag == "YellowBox" || other.gameObject.tag == "RedBox")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }


    }
}
