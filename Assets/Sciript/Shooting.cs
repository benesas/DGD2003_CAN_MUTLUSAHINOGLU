using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float range = 100f;
    public Camera cam;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, range))
            {
                Debug.Log("Hit: " + hit.transform.name);
            }
        }
    }
}