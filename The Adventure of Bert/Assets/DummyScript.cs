using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyScript : MonoBehaviour
{

    public float Health = 50;

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name.Equals("PP_Sword_0363"))
        {
            Health = Health - 10;
            
            if(Health < 1)
            {
                ifDead();
            }
        }
    }
    public void ifDead()
    {
        Destroy(gameObject);
    }
}
