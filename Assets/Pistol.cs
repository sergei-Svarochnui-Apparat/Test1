using UnityEngine;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;

public class Pistol : AllWeapon
{
    private void Update()
    {

        if (Ammo > 0 && Input.GetButtonDown("Fire1"))
        {
            Shoot();
            Ammo --;
        }
        if (Ammo == 0 && Input.GetKey(KeyCode.R))
        {
            Reload();
            Ammo = MaxAmmoMagazin;
        }

    }
}
