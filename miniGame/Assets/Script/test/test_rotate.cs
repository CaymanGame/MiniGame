using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
          //transform.rotation = Quaternion.AngleAxis(30, Vector3.up);
	}
     public float m_angle = 10f;
	// Update is called once per frame
	void Update () {
          if (Input.GetKeyDown(KeyCode.D))
          {
               transform.rotation = Quaternion.AngleAxis(m_angle, Vector3.up);
          }
          
	}
}
