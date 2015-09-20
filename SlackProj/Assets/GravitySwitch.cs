using UnityEngine;
using System.Collections;

public class GravitySwitch : MonoBehaviour {

    // Use this for initialization
    public GameObject prnt;
    public Rigidbody body;
    void Start () {
        prnt = GameObject.Find("CubeParent");
        body = GetComponent<Rigidbody>();
        
	
	}
	
	// Update is called once per frame
	void Update () {
        //print(prnt.transform.rotation.eulerAngles.x);

        if (prnt.transform.rotation.eulerAngles.x > 2 && prnt.transform.rotation.eulerAngles.x < 358)
        {
            body.useGravity = true;
        }
	
	}
}
