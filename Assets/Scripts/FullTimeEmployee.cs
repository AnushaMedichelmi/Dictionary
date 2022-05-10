using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTimeEmployee : MonoBehaviour
{
    private void Start()
    {
        MonthlySalary();
    }
    public int salary;
    public override void MonthlySalary()
    {
        Debug.Log("Full time salary : " + salary);

    }
}
