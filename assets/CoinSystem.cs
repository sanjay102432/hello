using UnityEngine;
using TMPro;

public class CoinSystem : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    int coins = 0;

    public void AddCoin()
    {
        coins++;
        coinText.text = "Coins: " + coins;
    }
}