using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTimeEmployee : MonoBehaviour
{
    private void Start()
    {
        MonthlySalary();
    }
    public int hoursWorked;
    public int hourlyRate;
    public override void MonthlySalary()
    {
        Debug.Log(hourlyRate * hoursWorked);

    }

}
