using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerAndAge : MonoBehaviour
{
    public Dictionary<string, int> footballPlayers = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        footballPlayers.Add("Ali", 12);
        footballPlayers.Add("Masuna", 2);
        footballPlayers.Add("WFH", 92);
        footballPlayers.Add("Willem", 56);

        var footballPlayerAge = footballPlayers["Masuma"];

        Debug.Log(footballPlayerAge);

        foreach (KeyValuePair<string, int> item in footballPlayers)
        {
            Debug.Log("Age" + item.Value);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
