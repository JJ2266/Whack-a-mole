using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class logic : MonoBehaviour
{
    [SerializeField]Slider timer;
    [SerializeField]float timeRemaining;
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        
        
        
        timer.value = timeRemaining;

        if (timer.value <= 0 )
        {
            gameOver();
        }

        if (timeRemaining >= 10)
        {
            timeRemaining = 10;
        }
        
    }
     public float addTime(float amount)
    {
        timeRemaining += amount;
        return timeRemaining;
        
    }

    void gameOver()
    {
        SceneManager.LoadScene("gameOver");
    }

}
