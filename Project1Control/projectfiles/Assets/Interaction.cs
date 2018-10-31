using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    private Renderer rend;
    public Color col;
    private Color startColor;
    // Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
	}

    void OnMouseEnter()
    {
        rend.material.color = col;
    }
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButton(0)) { 

            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }
        else if (Input.GetMouseButton(1)) { 
            transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
        }
        else{
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
