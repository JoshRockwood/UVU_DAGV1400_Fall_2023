using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float initialHealth = 100f;
    private float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = initialHealth;
    }

    // Update is called once per frame
    public void UpdateHealthWithFloatData(FloatData floatData)
    {
        currentHealth += floatData.value;
    }
}
