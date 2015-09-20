using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

    // Use this for initialization
    float tilt;
    float recover;
    void Start () {
         tilt = Random.Range(.1f, -.1f);
    }
	
	// Update is called once per frame
	void Update () {

        recover = transform.rotation.eulerAngles.x;
        print(recover);

        transform.Rotate(tilt, 0, 0);

        if (Input.GetKey("left")) {
            tilt = -.2f;
            transform.Rotate(tilt, 0, 0);
            
        }

        if(Input.GetKey("right"))
        {
            tilt = .2f;
            transform.Rotate(tilt, 0, 0);
            
        }

        if (Input.GetKeyDown("space"))
        {
            print("RECOVERED");
            print(recover);
            print("END");
            transform.Rotate(-recover*3 , 0, 0);
            

        }
	}
}
