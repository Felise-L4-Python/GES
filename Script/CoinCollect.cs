using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class itemcollect : MonoBehaviour
{
    private int coinCount = 0;
    [SerializeField] private Text coinText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "collectable")
        {
            Destroy(collision.gameObject);
            coinCount += 1;
            coinText.text = "Coin Count:" + coinCount;
        }
    }
}