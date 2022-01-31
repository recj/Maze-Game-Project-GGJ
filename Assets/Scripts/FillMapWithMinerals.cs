using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillMapWithMinerals : MonoBehaviour
{
    public Transform prefab;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 25; i++){
            Instantiate(prefab, new Vector3(Random.Range(200, 300), 0.4f, Random.Range(280, 418)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
