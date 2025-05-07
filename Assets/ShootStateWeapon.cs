using UnityEngine;

public class ShootStateWeapon : IStateWeapon
{
    public void Enter(AllWeapon allWeapon)
    {
        allWeapon._Animator.SetTrigger("OnShoot");
        allWeapon.ShootRayCast();

    }
    public void Exit(AllWeapon allWeapon)
    {
        
    }
}
