using UnityEngine;
using System.Collections;

public class pushController : MonoBehaviour {
    public GameObject settings;

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("MovePushUp")) {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (Input.GetButtonDown("MovePushDown")) {

        }
        if (Input.GetButtonDown("MovePushLeft")) {

        }
        if (Input.GetButtonDown("MovePushRight")) {

        }
    }
}
