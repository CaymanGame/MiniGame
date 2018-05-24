using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 测试点击，射线发送到3d空间中
/// </summary>
public class testGetTouchDot : MonoBehaviour {
     public GameObject m_move = null;
	// Use this for initialization
	void Start () {
          
	}
	
	// Update is called once per frame
	void Update () {
          if (Input.GetMouseButtonDown(0))
          {
               //从屏幕空间点击，发射射线到3d空间中
               Ray t_cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
               RaycastHit t_rayhit;
               if (Physics.Raycast(t_cameraRay,out t_rayhit))
               {
                    Vector3 t_hitPoint = t_rayhit.point;
                    //Debug.Log("<color=blue>blue:</color>" + t_hitPoint);
                    if (m_move != null)
                    {
                         m_move.transform.position = t_hitPoint;
                    }
               }
               
          }
		
	}
}
