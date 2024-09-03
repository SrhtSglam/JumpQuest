using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    [SerializeField] GameObject platform, coin, dirt;

    private void Awake()
    {
        float grassX = platform.transform.position.x;
        float grassY = platform.transform.position.y;
        float dirtX = dirt.transform.position.x, dirtY = dirt.transform.position.y;
        float coinX = coin.transform.position.x;
        float coinY = coin.transform.position.y;
        for(int i = 0; i < 50; i++) 
        {
            dirtX += 1;
            grassX += 1;
            Instantiate(platform, new Vector2(grassX,grassY), Quaternion.identity);
            Instantiate(dirt, new Vector2(dirtX, dirtY), Quaternion.identity);
            if(i > 15)
            {
                coinX += 7;
                Instantiate(coin, new Vector2(coinX, coinY), Quaternion.identity);
            }
        }
    }
}
