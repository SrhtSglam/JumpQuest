using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    [SerializeField] GameObject platform, coin;

    private void Awake()
    {
        float grassX = platform.transform.position.x;
        float grassY = platform.transform.position.y;
        float coinX = coin.transform.position.x;
        float coinY = coin.transform.position.y;
        for(int i = 0; i < 50; i++) 
        {
            grassX += 1;
            Instantiate(platform, new Vector2(grassX,grassY), Quaternion.identity);
            if(i > 15)
            {
                coinX += 3;
                Instantiate(coin, new Vector2(coinX, coinY), Quaternion.identity);
            }
        }
    }
}
