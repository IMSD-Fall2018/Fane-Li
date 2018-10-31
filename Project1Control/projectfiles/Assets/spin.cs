using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {


    public float speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Rotate on it own center
        //transform.Rotate(Vector3.up, speed * Time.deltaTime);


        //rotate sides
        transform.Rotate(Time.deltaTime, 0, 1);



    }
}
