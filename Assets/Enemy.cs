using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int speed;
    public int health;
    public abstract void Attack();
    public virtual void Death()
    {
        Debug.Log("Iam dead");
    }


}
public class Robot : Enemy //Inherit
{
    public override void Attack()
    {

    }
    public override void Death()
    {
        base.Death();
    }
    /*
    void Damage(10)
    {
        Debug.Log("The passed value is 10");
    }*/
}

