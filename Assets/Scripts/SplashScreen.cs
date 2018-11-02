using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {


    IEnumerator Splash_Screen()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel(1);
    }

    void Start () {
        StartCoroutine(Splash_Screen());
	}
    
   
	
}
