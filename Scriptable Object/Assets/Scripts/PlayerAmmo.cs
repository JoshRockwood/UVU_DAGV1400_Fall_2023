using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmo : MonoBehaviour
{
    public int initialAmmo = 20;
    private int currentAmmo;
    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = initialAmmo;
    }

    public void UpdateAmmoWithIntData(IntData intData)
    {
        currentAmmo += intData.value;
    }
}
