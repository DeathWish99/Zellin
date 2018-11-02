using UnityEngine;
using System.Collections;

public class SplashScreenUnity : MonoBehaviour {


    IEnumerator SplasshScreenUnity()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel(2);
    }

    void Start () {
        StartCoroutine(SplasshScreenUnity());
	}
    
   
	
}
