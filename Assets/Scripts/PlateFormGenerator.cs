using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateFormGenerator : MonoBehaviour
{
    public GameObject PlateForm;
    public Transform PlateFormGenPoint;
    private float width;
    // Start is called before the first frame update
    void Start()
    {
        width = PlateForm.GetComponent<BoxCollider2D>().size.x;
        //x from rotation position scale

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < PlateFormGenPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + width,transform.position.y,transform.position.z);
            Instantiate(PlateForm,transform.position,transform.rotation);
        }
    }
}
