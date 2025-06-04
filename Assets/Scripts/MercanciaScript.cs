﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public MONEYMANAGER moneyManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MONEYMANAGER>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.name == "Player")
        {
           bool leAlcanza = moneyManager.UpdateMoney(-precio);
            if (leAlcanza)
            {
                Destroy(gameObject);
            }
        };
    }
}
