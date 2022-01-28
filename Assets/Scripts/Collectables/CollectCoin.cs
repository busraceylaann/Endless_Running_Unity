using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
    public GameObject menuAndCoin;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        this.gameObject.SetActive(false);
        menuAndCoin.GetComponent<menuAndCoin>().addCoin();
    }
    
}
