using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    public int Score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Score.ToString();
    }
    public int addScore(int amount)
    {
        Score += amount;
        return Score;
    }

}
