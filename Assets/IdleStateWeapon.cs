using UnityEngine;

public class IdleStateWeapon : IStateWeapon
{
    public void Enter(AllWeapon allWeapon)
    {
        Debug.Log("� idle");
    }
    public void Exit(AllWeapon allWeapon)
    {

    }
}
