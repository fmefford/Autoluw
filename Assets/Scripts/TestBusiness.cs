using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBusiness : BusinessMasterController

{
    //how much population can support one of a business
    int carryingCapacity = 15000;

    int revenue;
    int costs;
    int profit;

    int coolness = 4;

    int minTransitSupport;

    int employees;

    List<string> listNames = new List<string>() { };
    listNames.Add();
    print(listNames);

    //TODO
    //change to type meeple when possible
    List<int> employeeType = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        profit = revenue - costs;
        
    }

    // Update is called once per frame
    
}
