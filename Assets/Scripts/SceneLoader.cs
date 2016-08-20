using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour {
	
	public void LoadNextScene(int number)
    {
        SceneManager.LoadScene(number);
    }
}
