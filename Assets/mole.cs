using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class mole : MonoBehaviour
{
    score scorescript;
    logic logicScript;
    public int lifetime = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,lifetime);
        scorescript = FindObjectOfType<score>();
        logicScript = FindObjectOfType<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        Destroy(gameObject);
        scorescript.addScore(1);
        logicScript.addTime(0.7f);
        
    }
   
}
