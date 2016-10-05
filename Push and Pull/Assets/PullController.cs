using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PullController : MonoBehaviour {
    enum direction {LEFT, CENTER, RIGHT};
    bool isPulling = false;
    public GameObject pulledObject = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Fire1")) {
            isPulling = false;
            pulledObject = null;
        }

        updatePulledObject();
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "interactive" && Input.GetButton("Fire1") && !isPulling) {
            pulledObject = col.gameObject;
            isPulling = true;
        }
    }

    void updatePulledObject() {
        if (pulledObject) {
            float pulledObjectXPos = pulledObject.GetComponent<Rigidbody2D>().position.x;
            float selfXPos = GetComponent<Rigidbody2D>().position.x;
            direction relativeObjectPosition = direction.CENTER;
            direction directionOfMovement = direction.CENTER;

            if (pulledObjectXPos > selfXPos) {
                relativeObjectPosition = direction.RIGHT;
            } else if (pulledObjectXPos < selfXPos) {
                relativeObjectPosition = direction.LEFT;
            }

            if (CrossPlatformInputManager.GetAxis("Horizontal") > 0) {
                directionOfMovement = direction.RIGHT;
            } else if (CrossPlatformInputManager.GetAxis("Horizontal") < 0) {
                directionOfMovement = direction.LEFT;
            }

            if (relativeObjectPosition != directionOfMovement) {
                pulledObject.GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity;
            }
        }
    }
}
