using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBear : MonoBehaviour {

    bool printedMessage = false;

	// Use this for initialization
	void Start () {
        print("Hello world from old ASUS");
	}
	
	// Update is called once per frame
	void Update () {
        if (!printedMessage &&
            Time.time > 2) {
            print("2 seconds message from msi");
            printedMessage = true;
        }
		
	}
}
