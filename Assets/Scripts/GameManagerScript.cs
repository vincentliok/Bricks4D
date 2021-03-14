using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [System.NonSerialized]
    public List<GameObject> ballPool;

    [SerializeField]
    private GameObject ballpf;

    [SerializeField]
    private int poolSize;

    // Start is called before the first frame update
    void Start()
    {
        ballPool = new List<GameObject>();
        GameObject temp;
        for (int i = 0; i < poolSize; i++)
        {
            temp = Instantiate(ballpf);
            temp.SetActive(false);
            ballPool.Add(temp);
        }

        ballPool[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
