using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusinessMasterController : MonoBehaviour
{
    //how much population can support one of a business
    int carryingCapacity;

    int revenue;
    int costs;
    int profit;

    int coolness;

    int minTransitSupport;

    int employees;
    //TODO
    //change to type meeple when possible
    List<int> employeeType = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        profit = revenue - costs;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateFinancials(int newRevenue, int newCosts)
    {
        this.revenue = newRevenue;
        this.costs = newCosts;
        this.profit = this.revenue - this.costs;
    }
}
