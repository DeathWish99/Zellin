using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    public int index = 3;
	
    public void ChangeScene(int index) { 
           SceneManager.LoadScene(index);
    }


}
