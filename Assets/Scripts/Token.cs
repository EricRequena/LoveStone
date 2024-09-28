using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : Fighter
{
    public int Position;
    public int CurrentDamage;
    public int CurrentHP;
    public CharacterSO Character;

    void Start()
    {

    }

    void Update()
    {

    }

    public void SetToken()
    {
        GameManager.gameManager.TokenHP.text = this.Character.HP.ToString();
        GameManager.gameManager.TokenAttack.text = this.Character.Damage.ToString();
        GameManager.gameManager.TokenImage.sprite = this.Character.Design;
    }   
}

