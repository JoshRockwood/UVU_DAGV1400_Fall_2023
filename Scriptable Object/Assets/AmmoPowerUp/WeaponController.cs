using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public IntData intData;
    public PlayerAmmo playerAmmo;

    public void AddAmmo()
    {
        playerAmmo.UpdateAmmoWithIntData(intData);
    }
}
