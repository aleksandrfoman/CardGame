using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Card
{
    public string Name;
    public Sprite Logo;
    public int Attack, Defense;

    public Card(string name, string logo, int attack, int defense)
    {
        Name = name;
        Logo = Resources.Load<Sprite>(logo);
        Attack = attack;
        Defense = defense;
    }
}

public static class CardManager
{
    public static List<Card> AllCards = new List<Card>();
}

public class CardManagerScr : MonoBehaviour
{
    private void Awake()
    {
        CardManager.AllCards.Add(new Card("Жырнич", "Sprites/Cards/Cat1", 5, 5));
        CardManager.AllCards.Add(new Card("Собакич", "Sprites/Cards/Cat2", 5, 5));
        CardManager.AllCards.Add(new Card("Злобыч", "Sprites/Cards/Cat3", 5, 5));
        CardManager.AllCards.Add(new Card("Непонятнич", "Sprites/Cards/Cat4", 5, 5));
        CardManager.AllCards.Add(new Card("Гордыч", "Sprites/Cards/Cat5", 5, 5));
        CardManager.AllCards.Add(new Card("Викингч", "Sprites/Cards/Cat6", 5, 5));
    }
}
