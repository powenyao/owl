using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *  Basic CameraManager
 *  Before finding any better method, for control player camera
 *  Use this to link both player transform and assigned camera
 *  For different camera function, extend this class to use module
 *  And create each module as different camera funcitonality so we can easily test different funcitons
 */
public class CameraManager : MonoBehaviour
{
    public Camera l_camera;
    public Transform l_targetTransform;

    void Awake()
    {
        if(!l_camera)
        {
            Debug.LogError("[CameraManager] Camera is none!");
        }

        if(!l_targetTransform)
        {
            Debug.LogError("[CameraManager] Target is none!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // follow player position for now
        l_camera.transform.position = new Vector3(l_targetTransform.position.x, l_targetTransform.position.y, l_camera.transform.position.z);
    }
}
