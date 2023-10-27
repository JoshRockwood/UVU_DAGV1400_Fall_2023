using UnityEngine;

public class HealthController : MonoBehaviour
{
    public FloatData floatData;
    public PlayerHealth playerHealth;
    public float health;
    public void AddHealth()
    {
        playerHealth.UpdateHealthWithFloatData(floatData);
    }
}
