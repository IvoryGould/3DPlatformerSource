using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Vector3 pSpawn = new Vector3(240, 16, 314);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision enemy) {

        if (enemy.gameObject.tag == "Enemy") {

            Debug.Log("killtest");
            this.gameObject.transform.position = pSpawn;

        }



    }
}
