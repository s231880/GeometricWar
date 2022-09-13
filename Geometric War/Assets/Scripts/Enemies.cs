using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemies/Type", fileName = "Enemy_")]
public class Enemies : ScriptableObject
{
    [Tooltip("Enemy healt")]
    public int healt;

    [Tooltip("Damage inflicted to the player")]
    public int damageInflicted;

    [Tooltip("Damage suffered every time is hit")]
    public int damageSuffered;

    [Tooltip("Movement speed")]
    public int movementSpeed;


    private void Initialise()
    {

    }

    private void Hit()
    {
        healt -= damageSuffered;
        if (healt <= 0)
            Death();
    }

    private void Death()
    {

    }
}
