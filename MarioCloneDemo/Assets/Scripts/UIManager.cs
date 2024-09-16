using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

[SerializeField] TextMeshProUGUI coinText;
private int coinsCollected = 0;

public static UIManager instance;

// Singleton set up
// Singleton allows global access
private void Awake()
{
    if (instance == null)
    {
        // Sets Instance to be this instance of UIManager
        instance = this;
    }
    else 
    {
        // Tells Unity to never destroy this object
        Destroy(gameObject);
    }
}

public void UpdateCoinText(int coin)
{
    coinsCollected += coin;
    coinText.text = "Coins: " + coinsCollected;

    if (coinsCollected == 6){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
   
}
