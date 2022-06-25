using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinA : MonoBehaviour
{
    void Start(){
        gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory PlayerInventory = other.GetComponent<PlayerInventory>();
        if (PlayerInventory != null)
        {
            PlayerInventory.KoinTerkumpul();
            gameObject.SetActive(false);
        }
    }  
}
