using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public GameObject ball ;
    int random ;
    int changementDeChoix;
    bool joue;
    float speed = 1 ;

    // Start is called before the first frame update
    void Start()
    {
        changementDeChoix = 0 ;
        joue = true ;
    }

    // Update is called once per frame
    void Update()
    {
       if(joue == true)
        {
           
            this.transform.position = new Vector3(ball.transform.position.x * speed , this.transform.position.y, this.transform.position.z);
        }
       else
        {
            speed -= 0.25f ;
            joue = true ;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("nombre de tour avant changement" + changementDeChoix);
    
    Debug.Log("IA a joué ");
        if ( changementDeChoix == 0)
        {
            if(Random.Range(0,2) == 1)
            {
                Debug.Log("J'essaye de gagner");
                joue = true ;
            }
            else
            {
                Debug.Log("Je doit perdre de perde");
                joue = false ;
            }
           Debug.Log("changement de tactique");
            random = Random.Range(1, 3);
            changementDeChoix = random ;
            Debug.Log("nombre de tour avant changement" + changementDeChoix );
        }
        changementDeChoix -= 1 ; 
    }
}
