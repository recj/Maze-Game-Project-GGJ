using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillMapWithMinerals : MonoBehaviour
{
    public Transform prefab;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 10; i++){
            Instantiate(prefab, new Vector3(Random.Range(200, 300), 10, Random.Range(280, 400)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
