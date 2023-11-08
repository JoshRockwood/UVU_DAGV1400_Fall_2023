using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehavior : MonoBehaviour
{
    private Image imageObj;
    public UnityAction raiseNoArgs;
    public UnityEvent startEvent, updateImageEvent;

    private void Start()
    {
        imageObj = GetComponent<Image>();
        raiseNoArgs += OnUpdate;
        startEvent.Invoke();
    }

    public void OnUpdate()
    {
        updateImageEvent.Invoke();
    }

    public void UpdateWithFloatData(FloatData dataObj)
    {
        imageObj.fillAmount = dataObj.value;
    }
}