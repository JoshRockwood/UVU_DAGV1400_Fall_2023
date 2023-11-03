using UnityEngine;
using UnityEngine.Events;

public class OnDestroyBehavior : MonoBehaviour
{
    public UnityEvent destroyEvent;

    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }
}
