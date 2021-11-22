using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    public int potionHealth = 12;
    

    public void DrinkPotion()
    {
        Player.instance.Health(potionHealth);
    }
}
