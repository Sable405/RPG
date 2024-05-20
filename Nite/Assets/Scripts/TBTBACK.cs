using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TBTBACK : MonoBehaviour
{
    public GameObject Bedroom;
     public GameObject TBT;
    public GameObject PPlayer;
    public Transform waypoint; 
    private bool isPlayerInTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        Bedroom.SetActive(false);
        TBT.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            Bedroom.SetActive(true);
            TBT.SetActive(false);
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
