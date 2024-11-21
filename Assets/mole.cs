using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class mole : MonoBehaviour
{
    score scorescript;
    logic logicScript;
    public int lifetime = 1;
    [SerializeField]int health = 1;
    [SerializeField] float timeAdded = 0.7f;
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
        if (health<= 0)
        {
            Destroy(gameObject);
        }
    }

    public void ButtonClicked()
    {
        health--;
        scorescript.addScore(1);
        logicScript.addTime(timeAdded);

    }
   
}
