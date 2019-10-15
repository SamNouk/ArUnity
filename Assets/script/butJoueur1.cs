using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butJoueur1 : MonoBehaviour
{
    public GameObject ball ;
    float score ;
    public Text countText ;
    public GameObject IAtoReset ;
    public GameObject respwan;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        setCountText();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("but");
        score += 1 ;
        setCountText();
        ball.transform.position = respwan.transform.position ; // new Vector3(respwan.transform.position.x , ball.transform.position.y + 10 , respwan.transform.position.z );  
    }

    void setCountText()
    {
        countText.text = score.ToString() ; 
    }
}
