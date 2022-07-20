using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    GameObject destroyer;

    // Start is called before the first frame update
    void Start()
    {
        destroyer = GameObject.Find("Destroy");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < destroyer.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
