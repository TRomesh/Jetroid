using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject targert;
    public float scale = 4f;
    private Transform t;

    void Awake()
    {
        var cam = GetComponent<Camera>();
        cam.orthographicSize = (Screen.height / 2f) / scale;
    }

	// Use this for initialization
	void Start () {
        t = targert.transform;	
	}
	
	// Update is called once per frame
	void Update () {
		 if(targert != null)
        {
            transform.position = new Vector3(t.position.x, t.position.y, transform.position.z);
        }
	}
}
