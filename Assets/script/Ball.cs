using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 direction = new Vector3(0.5f,0,-0.5f);
    public float speed = 100 ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 d = this.transform.TransformDirection(direction);
        GetComponent<Rigidbody>().velocity = d * speed * Time.fixedDeltaTime ;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Wall")
        {
           Vector3 normal = this.transform.InverseTransformDirection(collision.contacts[0].normal);
           direction = Vector3.Reflect(direction,normal);
        }
    }
}
