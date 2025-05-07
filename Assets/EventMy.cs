using System;
using UnityEngine;

public class EventMy : MonoBehaviour
{
    public static Action die;

    private void Start()
    {
        die += Loses; 
    }
    public void Loses()
    {
        print("First +");

    }
    private void OnDestroy()
    {
        die -= Loses;
    }
}
