using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseAnim : MonoBehaviour {
    public bool select;

	// Use this for initialization
	void Start () {
        gameObject.SetActive(select);

    }
}
