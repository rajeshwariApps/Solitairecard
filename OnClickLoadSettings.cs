using UnityEngine;
using System.Collections;
	using UnityEngine.SceneManagement;	

public class OnClickLoadSettings : MonoBehaviour {
		
	public void loadByIndex(int sceneIndex)
	{
		SceneManager.LoadScene (sceneIndex);
        Time.timeScale = 1;
	}

} 