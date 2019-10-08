using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockManager : MonoBehaviour
{
    public GameObject birdPrefab;
    public int numBird;
    public GameObject[] allBirds;
    public Vector3 limit = new Vector3(5, 3, 5);

    public Vector3 goalPosition;

    [Header("Bird Settings")]
    [Range(0.0f, 5.0f)]
    public float minSpeed;
    [Range(0.0f, 5.0f)]
    public float maxSpeed;
    [Range(1.0f, 10.0f)]
    public float neighbor;
    [Range(0.0f, 5.0f)]
    public float rotation;

    // Start is called before the first frame update
    void Start()
    {
        allBirds = new GameObject[numBird];

        for (int i = 0; i < numBird; i++)
        {
            Vector3 pos = this.transform.position + new Vector3(Random.Range(-limit.x, limit.x),
                                                                Random.Range(-limit.y, limit.y),
                                                                Random.Range(-limit.z, limit.z));
            allBirds[i] = (GameObject)Instantiate(birdPrefab, pos, Quaternion.identity);
            allBirds[i].GetComponent<Flock>().myManager = this;
        }

        goalPosition = this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //Randomizes the Goal
        //if(Random.Range(0,100) < 10)
        //{
            //goalPosition = this.transform.position + new Vector3(Random.Range(-limit.x, limit.x),
              //                                                    Random.Range(-limit.y, limit.y),
              //                                                    Random.Range(-limit.z, limit.z));
        //}
    }
}
