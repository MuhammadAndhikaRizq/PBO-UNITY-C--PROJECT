using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Generating Human");
        //Human
        //Objek class variabel = keyword constructor
        Human human = new Human("kaka", "dhika", 10);

        //Testing Properties
        Debug.Log(human.FirstName);
        Debug.Log(human.FullName);

        //Testing Methods
        Debug.Log("Apakah benar ini manusia? " + " " + human.IsValid());
        Debug.Log("Apakah dia sudah dewasa? " + " " + human.IsDewasa());
        Debug.Log("Panjang Karakter nama " + human.SizeFullName());

        Debug.Log("Generating Player");
        //Player
        Player player = new Player("Tobi", "Obito", 19, "tobi@ne.gmail");

        Debug.Log(player.FirstName);
        Debug.Log(player.FullName);
        Debug.Log(player.OneLiveID);

        //Player mengalahkan monster
        player.IncrementScore(100);
        Debug.Log("Score Player : " + player.GetScore().Points);
        player.IncrementScore(100);
        player.IncrementScore(100);
        Debug.Log("Score Player : " + player.GetScore().Points);
    }

}
