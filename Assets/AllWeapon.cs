using UnityEngine;

public class AllWeapon : MonoBehaviour
{
    [Header("Weapon Settings")]
    [SerializeField] protected int Ammo = 7;
    [SerializeField] protected int MaxAmmoMagazin = 49;
    [SerializeField] protected int Damage = 10;
    [SerializeField] protected float Range = 100f;

    private IStateWeapon _IStateWeapon;
    private Camera _PlayerCamera;
    public Animator _Animator;

    private void Start()
    {
        _IStateWeapon = new IdleStateWeapon();
        _IStateWeapon.Enter(this);
        _PlayerCamera = Camera.main;
    }
    
    public void ShootRayCast()
    {
        Ray ray = _PlayerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Range))
        {
            Target EnemyTarget = hit.collider.GetComponent<Target>();
            if (EnemyTarget != null)
            {
                EnemyTarget.TakeDamage(Damage);
            }
        }
    }
    public void Update()
    {
        print(_IStateWeapon);
    }

    public void ChangedState(IStateWeapon NewState)
    {
        _IStateWeapon.Exit(this);
        _IStateWeapon = NewState;
        _IStateWeapon.Enter(this);
        print(NewState);
    }
    public void Shoot()
    {
        ChangedState(new ShootStateWeapon());
    }
    public void Reload()
    {
        ChangedState(new ReloadStateWeapon());
    }
    public void AimWeapon() 
    {

    }
}
