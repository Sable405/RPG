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
    private bool hasTransitioned = false;

    void Update()
    {
        if (isPlayerInTrigger && !GameManager.Instance.IsCooldownActive() && !hasTransitioned)
        {
            TBT.SetActive(false);
            DownStairs.SetActive(true);
            PPlayer.transform.position = waypoint.position;
            hasTransitioned = true;
            GameManager.Instance.StartCooldown();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PPlayer)
        {
            isPlayerInTrigger = true;
            hasTransitioned = false;
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
