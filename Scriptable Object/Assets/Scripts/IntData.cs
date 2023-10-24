using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int gold;

    public void UpdateValue(int amount)
    {
        gold += amount;
    }
}
