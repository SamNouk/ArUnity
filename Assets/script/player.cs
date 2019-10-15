using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float WidthScreen ;
    float movementSpeed;
    public GameObject limiteGauche;
    public GameObject limiteDroite;
    // Start is called before the first frame update
    void Start()
    {
      
        WidthScreen = Screen.width ;
        movementSpeed = 5f ;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Debug.Log("position joueur: " + this.transform.position.x);
        Debug.Log("position limite gauche: " + limiteGauche.transform.position.x);

        Vector3 d = this.transform.TransformDirection(this.transform.position);

        if (Input.GetKey(KeyCode.Mouse0)){
            Debug.Log("click");
            Debug.Log("this.transform.position.x " + this.transform.position.x.ToString());
            Debug.Log("Test" + d.x);
            Debug.Log("Test 2 " + this.transform.position.x);
            if (Input.mousePosition.x > WidthScreen / 2)
            {
                Debug.Log("gauche");
                this.transform.position += -this.transform.forward * movementSpeed * Time.deltaTime;

            }
            else if (Input.mousePosition.x < WidthScreen / 2)
            {
                Debug.Log("");
                this.transform.position += this.transform.forward * movementSpeed * Time.deltaTime;

            }
        }

        if (this.transform.position.x < limiteDroite.transform.position.x + 0.65 )
        { 
            Debug.Log("depasse a droite");
            this.transform.position += this.transform.forward * movementSpeed * Time.deltaTime;
        }

        if (this.transform.position.x > limiteGauche.transform.position.x - 0.50 )
        { 
            //todo
            Debug.Log("depasse a gauche");
            this.transform.position -= this.transform.forward * movementSpeed * Time.deltaTime;
        }


        /*if (this.transform.position.x >= 2.03)
        {
            this.transform.position = this.transform.TransformDirection(new Vector3(2.03f, this.transform.position.y, this.transform.position.z));
        }*/

    }
    /*
     * if(Input.mousePosition.x > WidthScreen / 2)
            {
                Debug.Log("gauche");
                this.transform.position  = transform.position + new Vector3(1 * movementSpeed * Time.deltaTime, 0 , 0);

            }
            if (Input.mousePosition.x < WidthScreen / 2)
            {
                Debug.Log("");
                this.transform.position  = transform.position + new Vector3( -1 * movementSpeed * Time.deltaTime, 0 , 0);

            }
     */

    /*
     *  if (this.transform.position.x <= -2.13f)
        {
            this.transform.position = this.transform.TransformDirection(new Vector3( -2.13f, this.transform.position.y, this.transform.position.z)) ;
        }
        if (this.transform.position.x >= 2.03)
        {
            this.transform.position = this.transform.TransformDirection(new Vector3(2.03f, this.transform.position.y, this.transform.position.z));
        }
     * */
}
