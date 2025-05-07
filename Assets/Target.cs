using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private int Health;

    public void TakeDamage(int Amount)
    {
        Health -= Amount;
        if (Health <= 0)
        {
            EnemyDied();
        }
        print(Health);
    }
    void EnemyDied()
    {
        Destroy(gameObject);
    }
}
