using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar: Fighter
{
    public Power Power;
    public int Armor;
    public EntitySO Entity;

    public void Interact()
    {
        
    }

    private void Start()
    {

    }

    private void Update()
    {

    }

    public void SetAvatar()
    {
        GameManager.gameManager.AvatarImage.sprite = this.Entity.Design;
    }


}

