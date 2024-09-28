using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public Text CharacterName, CharacterMana, CharacterHP, ChatarAttack, CharacterDescription, TokenAttack, TokenHP, PowerMana, SpellMana, SpellName, SpellDescription;
    public Image CharacterImage, AvatarImage, PowerImage, TokenImage, SpellImage;
    private void Awake()
    {
        if (GameManager.gameManager != null && GameManager.gameManager)
        {
            Destroy(this.gameObject);
        }

        gameManager = this;
    }
}
