using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera cam1;
    public CinemachineVirtualCamera cam2;
    public CinemachineVirtualCamera cam3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
            SetPriority(cam1);
        if (Input.GetKeyDown(KeyCode.Alpha6))
            SetPriority(cam2);
        if (Input.GetKeyDown(KeyCode.Alpha7))
            SetPriority(cam3);
    }

    void SetPriority(CinemachineVirtualCamera activeCam)
    {
        cam1.Priority = 0;
        cam2.Priority = 0;
        cam3.Priority = 0;

        activeCam.Priority = 10;
    }
}