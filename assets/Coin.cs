using UnityEngine;

public class Coin : MonoBehaviour
{
    public CoinSystem coinSystem;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            coinSystem.AddCoin();

            Destroy(gameObject);
        }
    }
}