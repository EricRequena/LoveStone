using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellCard : Card
{
    public EntitySO Spell;
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void SetCard()
    {
        GameManager.gameManager.SpellName.text = this.Spell.Name;
        GameManager.gameManager.SpellDescription.text = this.Spell.Description;
        GameManager.gameManager.SpellMana.text = this.Mana.ToString();
        GameManager.gameManager.SpellImage.sprite = this.Spell.Design;
    }


}