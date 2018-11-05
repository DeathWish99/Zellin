using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempMovement : MonoBehaviour {

    public float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 translation = new Vector3(speed * Time.deltaTime, 0, 0);

		if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(translation);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(translation * -1);
        }
	}
}
