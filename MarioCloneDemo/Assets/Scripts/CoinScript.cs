using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] public int coinValue = 1;

    public void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.CompareTag("Player"))
        {
             UIManager.instance.UpdateCoinText(coinValue);

             Destroy(gameObject);
        }
       
    }
}
