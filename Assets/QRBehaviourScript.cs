using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QRBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Drawsphere() {
        var mySphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        mySphere.transform.localScale = new Vector3(1,1,1);
        mySphere.transform.position = new Vector3(0, 0, 0);
    }

    public void GenerateQR()
    {
        QR
    }

}
