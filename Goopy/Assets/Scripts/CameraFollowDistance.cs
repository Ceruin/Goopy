using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraFollowDistance : MonoBehaviour
{
    CinemachineVirtualCamera vcam;
    float offsetcamz = 6.0f;
    float offsetcamy = 1.1f;

    // Start is called before the first frame update
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Voreable voreComponent = gameObject.GetComponent<Voreable>();
        float offsetz = ((vcam.m_Follow.localScale.z) * 1.6f) + offsetcamz;
        float offsety = ((vcam.m_Follow.localScale.y) * 1.05f) + offsetcamy;
        vcam.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset.z = offsetz;
        vcam.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset.y = offsety;


        /*
         * 
         * 
         * Player
         * Camera Player Size Set Multi distance
         * 
         * 
         * (5 + 5) 1.1
         * (100 + 5) * 1.1  
         * 
         * 
         */









    }
}
