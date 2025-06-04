using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MONEYMANAGER : MonoBehaviour
{
    public float money;

    public bool UpdateMoney(float amount)

    {
        if (money + amount < 0)
        {
            Debug.Log("No te alcanza");
            return false;
        }
        else
        { 
            money += amount;
            return true;
        }
    }
}
