using UnityEngine;

public class AmmoPowerUp : MonoBehaviour
{
    [SerializeField]private IntData ammoValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Add Ammo to player's weapon
            IncreaseAmmo(other.gameObject);

            //Destroy the power-up game object
            Destroy(gameObject);
        }
    }
    
    private void IncreaseAmmo(GameObject player)
    {
        // Retrieve the player's weapon component (Weapon Controller Script)
        WeaponController weaponController = player.GetComponent<WeaponController>();

        if (weaponController != null)
        {
            //Add ammo value to the player's current ammo
            weaponController.AddAmmo();
        }
    }
}
