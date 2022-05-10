using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColorUsingDelegate : MonoBehaviour
{
    // Start is called before the first frame update

    public delegate void ActionButtonClick();
    public static event ActionButtonClick onActionButtonClick;  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CubeColorChange()
    {
        if(onActionButtonClick != null)
        {
            onActionButtonClick();
        }
    }
}
