using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Collectable[] collectables;
    public int collectableRemain;
    public TextMeshProUGUI collectableText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        collectables = FindObjectsOfType<Collectable>();
        collectableRemain = collectables.Length;
        collectableText.text = collectableRemain.ToString() + " Remaining";
    }
}
