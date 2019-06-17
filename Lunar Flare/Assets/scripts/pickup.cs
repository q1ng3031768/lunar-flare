using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject orbstart;
    public GameObject orbmain;
    public GameObject player; 

    private void OnTriggerEnter(Collider other)
    {
        orbstart.SetActive(false);
        orbmain.SetActive(true);
        player.GetComponent<AudioSource>().enabled = true;
    }
}
