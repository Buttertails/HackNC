using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float marketRandomizer(float GoodsElasticity, float Price, float BasePrice) //elasticity should be between .01-1
    {
        float MarketIntensity = Random.Range(0.01f, 1.0f);
        int MarketCondition = Random.Range(0, 2);
        float NewPrice;
        float MarketSway;
        float BasePriceLow = BasePrice - 105.0f;
        float BasePriceHigh = BasePrice + 105.0f;
        float PriceFloor = 0.1f; //price will not be allowed lower than this point, consider raising

        if(MarketCondition == 0)
        {
            MarketCondition = -1;
        }

        MarketSway = MarketCondition * (GoodsElasticity * (MarketIntensity * 100));

        NewPrice = Price + (Price * (MarketSway / 100)); //consider an if loop when working with negatives

        if(NewPrice < PriceFloor)
        {
            NewPrice = PriceFloor;
        }

        if (NewPrice > BasePriceHigh) {
            NewPrice = BasePriceHigh;
        }
        else if (NewPrice < BasePriceLow) {
            NewPrice = BasePriceLow;
        }

        return NewPrice;
    }
}
