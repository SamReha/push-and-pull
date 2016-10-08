using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GateManager : MonoBehaviour {
    private bool transitioning = false;
    private bool chimePlayed = false;

    public Canvas canvas;
    public Text timeText;
    public GameObject redGate;
    public GameObject yellowGate;
    public GameObject push;
    public GameObject pull;
    public float timeToTransition = 3f;
    public string levelTarget = "main_menu";
    public bool redCollision = false;
    public bool yellowCollision = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (transitioning && timeToTransition > 0) {
            if (!chimePlayed) {
                GetComponent<AudioSource>().Play();
                chimePlayed = true;
            }

            canvas.gameObject.SetActive(true);
            timeToTransition -= Time.deltaTime;
            timeText.text = "Next Level In " + System.Math.Ceiling(timeToTransition);

            if (timeToTransition <= 0) {
                if (levelTarget == "main_menu") {
                    GameObject.Find("/InGameAudioManager").GetComponent<InGameAudioManager>().stopMusic();
                }

                SceneManager.LoadScene(levelTarget);
            }
        } else {
            transitioning = bothPlayersAtGate();
        }
	}

    private bool bothPlayersAtGate() {
        return (redCollision && yellowCollision);
    }
}
