using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance { get; private set; }
    private bool isCooldown = false;
    public float cooldownTime = 1f; // 1 second cooldown

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartCooldown()
    {
        StartCoroutine(Cooldown());
    }

    public bool IsCooldownActive()
    {
        return isCooldown;
    }

    private IEnumerator Cooldown()
    {
        isCooldown = true;
        yield return new WaitForSeconds(cooldownTime);
        isCooldown = false;
    }
}
