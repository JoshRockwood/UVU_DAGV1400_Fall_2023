using UnityEngine;

public class GameObjectDisabler : MonoBehaviour
{
    private void OnEnable()
    {
        var triggerEventsBehavior = FindObjectOfType<TriggerEventBehavior>();

        if (triggerEventsBehavior != null)
        {
            triggerEventsBehavior.triggerExitEvent.AddListener(DisableGameObject);
        }
    }

    private void OnDisable()
    {
        var triggerEventsBehavior = FindObjectOfType<TriggerEventBehavior>();

        if (triggerEventsBehavior != null)
        {
            triggerEventsBehavior.triggerExitEvent.RemoveListener(DisableGameObject);
        }
    }

    private void DisableGameObject()
    {
        gameObject.SetActive(false);
    }
}
