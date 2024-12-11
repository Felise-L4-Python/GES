using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int coinCount = 0;
    public Text coinText;
    void Start()
    {
        if (coinText == null)

            UpdateCoinText();
    }
    public void AddCoin()
    {
        coinCount++;
        UpdateCoinText();
    }
    private void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Coin:" + coinCount;
        }
    }
}