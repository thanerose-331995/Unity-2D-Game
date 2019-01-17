using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBeams : MonoBehaviour {

    private SpriteRenderer rend;

    
    // Use this for initialization
    void Start () {
        rend = GetComponent<SpriteRenderer>();
        rend.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	}
}
