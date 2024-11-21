using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class moleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] molePrefabs;
    [SerializeField] Canvas canvas;
    mole molescript;
    score scorescript;
    logic gamemanager;
    public float timeBetweenSpawns;
    float elapsed = 0;
    float TotalTimeelapsed = 0;
    // Start is called before the first frame update
    void Start()
    {
    
        gamemanager = FindObjectOfType<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        TotalTimeelapsed += Time.deltaTime;

        if (elapsed>= timeBetweenSpawns)
        {
            spawn();
            elapsed = 0;
            
        }

       
    }
    private void spawn()
    {
        //spawn circles
        if(TotalTimeelapsed<= 20)
        {
            GameObject g = Instantiate(molePrefabs[0], canvas.transform);
            float x = Random.Range(50, canvas.GetComponent<RectTransform>().rect.width);
            float y = Random.Range(50, canvas.GetComponent<RectTransform>().rect.height);
            g.transform.position = new Vector2(x, y);
        }
        //start spawning triangles
        if (TotalTimeelapsed >= 20 && TotalTimeelapsed < 40)
        {
            gamemanager.MaxtimeRemaining = 9;
            GameObject g = Instantiate(molePrefabs[Random.Range(0,6)], canvas.transform);
            float x = Random.Range(50, canvas.GetComponent<RectTransform>().rect.width);
            float y = Random.Range(50, canvas.GetComponent<RectTransform>().rect.height);
            g.transform.position = new Vector2(x, y);
        }
        //start spawning squares
        if (TotalTimeelapsed >= 40 && TotalTimeelapsed < 60)
        {
            gamemanager.MaxtimeRemaining = 8;
            GameObject g = Instantiate(molePrefabs[Random.Range(0, 7)], canvas.transform);
            float x = Random.Range(50, canvas.GetComponent<RectTransform>().rect.width);
            float y = Random.Range(50, canvas.GetComponent<RectTransform>().rect.height);
            g.transform.position = new Vector2(x, y);
        }
        //start spawning hexagons
        if (TotalTimeelapsed >= 60)
        {
            gamemanager.MaxtimeRemaining = 6;
            GameObject g = Instantiate(molePrefabs[Random.Range(0, 8)], canvas.transform);
            float x = Random.Range(50, canvas.GetComponent<RectTransform>().rect.width);
            float y = Random.Range(50, canvas.GetComponent<RectTransform>().rect.height);
            g.transform.position = new Vector2(x, y);
        }
    }
    
}
