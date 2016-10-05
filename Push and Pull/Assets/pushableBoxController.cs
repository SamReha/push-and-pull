using UnityEngine;
using System.Collections;

public class pushableBoxController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /*void OnCollisionEnter2D(Collision2D col) {
        // Prevent Pull from being able to push boxes
        if (col.gameObject.tag == "Pull") {
            //Vector2 invertedForceOnBox = -col.rigidbody.velocity.normalized * col.rigidbody.mass;
            //Vector2 invertedForceOnPull = -GetComponent<Rigidbody2D>().velocity.normalized * GetComponent<Rigidbody2D>().mass;
            //col.gameObject.GetComponent<Rigidbody2D>().AddForce(invertedForceOnPull);
            //GetComponent<Rigidbody2D>().AddForce(invertedForceOnBox);
            Debug.Log(GetComponent<Rigidbody2D>().velocity);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

            //Debug.Log("Giving Pull a force of " + invertedForce);
        }
    }*/

    /*void OnTriggerEnter2D(Collider2D target) {
        Debug.Log("FART");
        Vector2 forceVec = -target.GetComponent<Rigidbody2D>().velocity.normalized;

        target.GetComponent<Rigidbody2D>().AddForce(forceVec);
    }*/

    /*function OnTriggerEnter(target_ : Collider) {
        var forceVec : Vector3 = -target_.rigidbody.velocity.normalized * explosionStrength;
        target_.rigidbody.AddForce(forceVec, ForceMode.Acceleration);
    }*/
}
