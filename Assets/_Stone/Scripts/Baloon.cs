﻿using UnityEngine;
using System.Collections;
namespace _Stone
{
    public class Baloon : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            MasterHouse house = collision.GetComponent<MasterHouse>();
            if (house)
            {
                house.AddScore(5);
            }
        }

    }

}
