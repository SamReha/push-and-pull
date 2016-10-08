using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InGameAudioManager : MonoBehaviour {
    private AudioSource music;

    private static InGameAudioManager instance = null;
    public static InGameAudioManager Instance {
        get { return instance; }
    }
    void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);

        music = GetComponent<AudioSource>();
    }

    void Update() {
        if (SceneManager.GetActiveScene().name != "main_menu") {
            if (!music.isPlaying) {
                music.Play();
            }
        } else {
            music.Stop();
        }
    }

    public void stopMusic() {
        music.Stop();
    }
}
