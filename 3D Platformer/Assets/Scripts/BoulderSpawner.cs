using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderSpawner : MonoBehaviour {

    public GameObject spawner;
    public GameObject boulder;
    bool tempbool = true;
	// Use this for initialization
	void Start () {
        StartCoroutine(Spawn());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Spawn() {
        //Debug.Log("B-test");
        while (tempbool == true) {

            //Debug.Log("Looptest");
            Instantiate(boulder, spawner.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2);

        }
    }
}
