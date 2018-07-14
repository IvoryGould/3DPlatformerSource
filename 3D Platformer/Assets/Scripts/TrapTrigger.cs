using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour {

    bool active = true;
    public GameObject trap;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool enter = true;

    void OnTriggerEnter(Collider other) {

        if (enter) {

            trap.SetActive(true);
            StartCoroutine(Toggle());
        }
    }

    IEnumerator Toggle()
    {

        while (active == true)
        {

            yield return new WaitForSeconds(3);
            trap.SetActive(false);
            yield return new WaitForSeconds(2);
            trap.SetActive(true);

        }
    }
}
