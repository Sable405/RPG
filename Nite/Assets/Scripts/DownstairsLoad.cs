using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownstairsLoad : MonoBehaviour
{
    public GameObject TBT;
     public GameObject DownStairs;
    public GameObject PPlayer;
    public Transform waypoint; 
    private bool isPlayerInTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
     //   TBT.SetActive(true);
      //  DownStairs.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInTrigger)
        {
            TBT.SetActive(false);
            DownStairs.SetActive(true);
            PPlayer.transform.position = waypoint.position;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PPlayer)
        {
            isPlayerInTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == PPlayer)
        {
            isPlayerInTrigger = false;
        }
    }
}
