using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void resetLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
