using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class CharacterCard : Card
{
    public CharacterSO Character;

    
    public void Invoke(Token token)
    {

    }
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void SetCard()
    {
        GameManager.gameManager.CharacterName.text = this.Character.Name;
        GameManager.gameManager.CharacterDescription.text = this.Character.Description;
        GameManager.gameManager.CharacterMana.text = this.Mana.ToString();
        GameManager.gameManager.CharacterHP.text = this.Character.HP.ToString();
        GameManager.gameManager.ChatarAttack.text = this.Character.Damage.ToString();
        GameManager.gameManager.CharacterImage.sprite = this.Character.Design;
    }
}

