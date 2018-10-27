using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    int index;
	
    public void ChangeScene(int index) { 
           SceneManager.LoadScene(index);
    }


}
