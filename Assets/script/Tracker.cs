using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Tracker : DefaultTrackableEventHandler
{
    public GameObject ball;
    public GameObject joueur1;
    /*
    private void Start()
    {
        ball.SetActive(true);
    }*/

    protected override void OnTrackingFound()
    {
        Debug.Log("TRACKING FOUND !!!!!! ");
        ball.SetActive(true) ;
        joueur1.SetActive(true) ;
    }

    protected override void OnTrackingLost()
    {
        ball.SetActive(false);
        joueur1.SetActive(false);
    }

}
