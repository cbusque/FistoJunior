using UnityEngine;
using System.Collections;

public class color : MonoBehaviour {

	// Use this for initialization
	void Start () {
       GetComponent<Renderer>().material.color = new Color(0.135F, 0.206F, 0.250F);
  


    }
	
	// Update is called once per frame
	void Update () {

    }
}
