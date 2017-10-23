using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public string destination;

	// Use this for initialization
	public void LoadLevel()
    {
        SceneManager.LoadScene(destination);
	}

}
