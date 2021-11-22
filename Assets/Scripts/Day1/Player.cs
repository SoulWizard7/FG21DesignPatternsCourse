using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance { get; private set; }

    public int health = 20;
    public int maxHealth = 100;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        
        //print(health);
    }

    public void Health(int getHealth)
    {
        health += getHealth;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    private void Start()
    {
        print(health);
    }
}
