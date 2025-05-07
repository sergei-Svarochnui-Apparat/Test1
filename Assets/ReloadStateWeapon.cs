using UnityEngine;

public class ReloadStateWeapon : IStateWeapon
{
    public void Enter(AllWeapon allWeapon)
    {
        //allWeapon._Animator.SetTrigger("OnReload");
        allWeapon._Animator.CrossFade("HumanArmature|Reload", 0.2f);
    }
    public void Exit(AllWeapon allWeapon)
    {
        
    }
}
