using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public WinGame winScreen;
    public GameObject pic;

    public CollectableSpawner spawner;
    public int maxRings;


    void Start()
    {
        pic.SetActive(false);
        Time.timeScale = 1;
    }


    void Update()
    {
        maxRings = GameObject.FindGameObjectsWithTag("Ring").Length;

        if(maxRings == 0 )
        {
            pic.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
