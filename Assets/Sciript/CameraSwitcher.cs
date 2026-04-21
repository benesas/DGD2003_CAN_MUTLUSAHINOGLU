using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera cam1;
    public CinemachineVirtualCamera cam2;
    public CinemachineVirtualCamera cam3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetCamera(cam1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetCamera(cam2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetCamera(cam3);
        }
    }

    void SetCamera(CinemachineVirtualCamera activeCam)
    {
        cam1.Priority = 0;
        cam2.Priority = 0;
        cam3.Priority = 0;

        activeCam.Priority = 10;
    }
}