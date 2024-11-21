using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class logic : MonoBehaviour
{
    [SerializeField] Slider timer;
    public float MaxtimeRemaining;
    [SerializeField] float currenttimeRemaining;
    

    // Start is called before the first frame update
    void Start()
    {
        currenttimeRemaining = MaxtimeRemaining;
    }

    // Update is called once per frame
    void Update()
    {
        currenttimeRemaining -= Time.deltaTime;
        
        
        
        timer.value = currenttimeRemaining;

        if (timer.value <= 0 )
        {
            gameOver();
        }

        if (currenttimeRemaining >= MaxtimeRemaining)
        {
            currenttimeRemaining = MaxtimeRemaining;
        }
        
    }
     public float addTime(float amount)
    {
        currenttimeRemaining += amount;
        return currenttimeRemaining;
        
    }

    void gameOver()
    {
        SceneManager.LoadScene("gameOver");
    }

}
