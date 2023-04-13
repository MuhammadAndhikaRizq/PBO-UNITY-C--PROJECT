using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extends class Human ditandai denga :
public class Player : Human
{
    private string oneLiveID;
    private Score score = new Score();

    //encapsulate membuat sebuah atribut dengan nilai getter setter, get mengambil nilai, set mengirim
    public string OneLiveID
    {
        get
        {
            return oneLiveID;
        }
    }
    //Override constructor
    //Constructor Player yang merefer dari class human. keywordnya adalah base
    public Player(string firstName, string lastName, int umur, string oneLiveID) : base(firstName, lastName, umur)
    {
        this.oneLiveID = oneLiveID;
    }

    //method
    public Score GetScore()
    {
        return score;
    }

    public void IncrementScore(decimal newScore)
    {
        score.points += newScore;
    }

    //encapsulate
    // public string oneLiveID{get => oneLiveID; set => oneLiveID = value;}
}
