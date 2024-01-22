using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    [SerializeField] public int coins;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            coins++;
            other.gameObject.SetActive(false);
        }
    }
    void Update()
    {
        
    }
}
