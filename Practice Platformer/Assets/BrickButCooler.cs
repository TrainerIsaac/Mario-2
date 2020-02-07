using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickButCooler : Brick
{
    public GameObject coin;
    protected override void Die()
    {
        base.Die();
        Instantiate(coin);
    }
}
