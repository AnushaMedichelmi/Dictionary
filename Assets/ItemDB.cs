using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{

    public List<Item> itemsList = new List<Item>(); 
   public Dictionary<int, Item> itemsDictionary = new Dictionary<int,Item>();
    // Start is called before the first frame update
    void Start()
    {
        Item MyKnife=new Item();
        MyKnife.Name = "Dictionary";
       MyKnife.Id = 0;
        
        Item MyBullet = new Item();
        MyBullet.Name = "Bullet";
        MyBullet.Id = 1;

        Item MyCar = new Item();
        MyCar.Name = "Hyundai";
        MyCar.Id = 2;

        itemsDictionary.Add(0, MyKnife);
        itemsDictionary.Add(1, MyBullet);
        itemsDictionary.Add(2, MyCar);

       /* foreach(KeyValuePair<int, Item> item in itemsDictionary)
        {
            Debug.Log(item.Key);
            Debug.Log(item.Value);
        }*/

      /*  foreach(Item item in itemsDictionary.Values)
        {
            Debug.Log(item.Name);
        }*/

        itemsList.Add(MyKnife);
        itemsList.Add(MyBullet);
        itemsList.Add(MyCar);

        foreach(Item item in itemsList)
        {
            Debug.Log(item.Name);
            Debug.Log(item.Id); 
        }

        var myDictionaryItem= itemsDictionary[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
