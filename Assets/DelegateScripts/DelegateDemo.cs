using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateDemo : MonoBehaviour
{
    // Start is called before the first frame update

    public delegate void ChangeColor(Color newColor);
    public ChangeColor OnChangeColor;
    public delegate void OnComplete();
    public OnComplete OnChangeComplete;
    void Start()
    {
        OnChangeColor = UpdateColor;
        OnChangeColor(Color.red);
        OnChangeComplete = TaskCompleted;
        OnChangeComplete();
    }

    private void TaskCompleted()
    {
        Debug.Log("Task Finished");
    }

    private void UpdateColor(Color newColor)
    {
        Debug.Log("Changing Color to:"+newColor.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
