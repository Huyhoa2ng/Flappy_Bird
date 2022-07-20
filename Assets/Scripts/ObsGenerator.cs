using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsGenerator : MonoBehaviour
{
    public Transform GenPoint;
    public GameObject obstical;

    float difference;
    public float minDx, maxDx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //randome.rage -- get any numbers from agruments
        difference = Random.Range(minDx, maxDx);
        if(transform.position.x < GenPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + difference, transform.position.y, transform.position.z);
            Instantiate(obstical, transform.position,transform.rotation);
        }
    }
}
