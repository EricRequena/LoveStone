using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : Invocable
{
    public EntitySO Entity;

    void Start()
    {

    }  

    void Update()
    {
        
    }

    public void SetPower()
    {
        GameManager.gameManager.PowerMana.text = this.Mana.ToString();
        GameManager.gameManager.PowerImage.sprite = this.Entity.Design;
      
    }
}

