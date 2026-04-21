using UnityEngine;
using UnityEngine.Events;

public class EventSender : MonoBehaviour
{
    public UnityEvent onAction;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            onAction.Invoke();
        }
    }
}