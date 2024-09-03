using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int coinAmount;
    [SerializeField] GameObject text;

    private void Awake()
    {
        coinAmount = 0;
    }

    private void Update()
    {
        text.GetComponent<TextMeshProUGUI>().text = "Coin: " + coinAmount.ToString();
    }
}
