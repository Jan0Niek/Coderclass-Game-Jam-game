using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachballSpawner : MonoBehaviour
{
    [SerializeField] private GameObject beachball;
    // Start is called before the first frame update
    void Start()
    {
        for ( int i = 0; i < 20; i++ )
        {
            Instantiate( beachball, new Vector3(Random.Range(-15,12), transform.position.y, Random.Range(-15, 12)), Quaternion.identity );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
