using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    [SerializeField] GameObject platform;

    private void Awake()
    {
        float x = platform.transform.position.x;
        float y = platform.transform.position.y;
        for(int i = 0; i < 30; i++) 
        {
            x += 1;
            Instantiate(platform, new Vector2(x,y), Quaternion.identity);
        }
    }
}
