using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class moleSpawner : MonoBehaviour
{
    [SerializeField] GameObject molePrefab;
    [SerializeField] Canvas canvas;
    mole molescript;
    score scorescript;
    public float timeBetweenSpawns;
    float elapsed = 0;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if (elapsed>= timeBetweenSpawns)
        {
            spawn();
            elapsed = 0;
            
        }

       
    }
    private void spawn()
    {
        GameObject g = Instantiate(molePrefab, canvas.transform);
        float x = Random.Range(50,canvas.GetComponent<RectTransform>().rect.width);
        float y = Random.Range(50, canvas.GetComponent<RectTransform>().rect.height);
        g.transform.position = new Vector2(x, y);
    }
    
}
