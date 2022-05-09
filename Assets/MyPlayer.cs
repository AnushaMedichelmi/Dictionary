using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    public Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();
    // Start is called before the first frame update
    void Start()
    {
        Player PlayerOne = new Player(1);
        PlayerOne.name = "Ali";
        Player PlayerTwo = new Player(19);
        PlayerTwo.name = "Reza";
        Player PlayerThree = new Player(9);
        PlayerThree.name = "Masuma";

        playerDictionary.Add(PlayerOne.id, PlayerOne);
        playerDictionary.Add(PlayerOne.id, PlayerOne);
        playerDictionary.Add(PlayerThree.id, PlayerThree);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var myDictionary = playerDictionary[20];
            Debug.Log("Player name" + myDictionary.name);
        }
    }
}
