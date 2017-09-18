using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public Color lerpedColor = Color.white;
    void Update()
    {

        GetComponent<SpriteRenderer>().color = Color.Lerp(Color.white, Color.gray, Mathf.PingPong(Time.time, 1));
    }
   
}
