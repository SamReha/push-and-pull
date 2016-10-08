using UnityEngine;
using System.Collections;

public class gateController : MonoBehaviour {
    public string playerTag;
    public GateManager gateManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == playerTag) {
            setGateManagerState(true);
        }

    }

    void OnTriggerExit2D(Collider2D col) {
        if (col.gameObject.tag == playerTag) {
            setGateManagerState(false);
        }

    }

    private void setGateManagerState(bool state) {
        switch (playerTag) {
            case "Pull":
                gateManager.yellowCollision = state;
                break;
            case "Push":
                gateManager.redCollision = state;
                break;
            default:
                break;
        }
    }
}
