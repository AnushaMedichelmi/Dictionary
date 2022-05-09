using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{

    public List<Item> itemsList = new List<Item>();
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();
    // Start is called before the first frame update
    void Start()
    {
        Item MySword = new Item();
        MySword.name = "Knife";
        MySword.id = 0;
        Item MyBullet = new Item();
        MyBullet.name = "Bullet";
        MyBullet.id = 1;
        Item MyCar = new Item();
        MyBullet.name = "Car";
        MyBullet.id = 2;

        itemDictionary.Add(0, MySword);
        itemDictionary.Add(1, MyBullet);
        itemDictionary.Add(2, MyCar);

        /*
        foreach (Item item in itemDictionary.Values)
        {
            Debug.Log("Name :" + item.name);
        }*/





        itemsList.Add(MySword);
        itemsList.Add(MyBullet);
        itemsList.Add(MyCar);
        /*
        foreach (var item in itemsList)
        {
            Debug.Log(item.name);
            Debug.Log(item.id);
        }*/
        var myDictionaryItem = itemDictionary[0];

        Debug.Log(myDictionaryItem.name);



    }


    // Update is called once per frame
    void Update()
    {

    }
}
