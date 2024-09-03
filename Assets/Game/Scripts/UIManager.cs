using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject panel;

    public void NewGameFunc()
    {
        PlayerPrefs.DeleteAll();
        panel.SetActive(false);
    }

    public void LoadGameFunc()
    {
        PlayerPrefs.GetInt("CoinValue");
        panel.SetActive(false);
    }
}
