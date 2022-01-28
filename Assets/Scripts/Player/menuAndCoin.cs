using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuAndCoin : MonoBehaviour
{
    public int coinCount = 0;
    public GameObject olumPaneli;
    public Text coinText, coinDeathText;

    public void Start()
    {
        coinCount = 0;
        olumPaneli.SetActive(false);
        coinText.text = coinCount.ToString();
    }

    public void addCoin() {
        coinCount += 1;
        coinText.text = coinCount.ToString();

    }
    public void die() {
        olumPaneli.SetActive(true);
        coinDeathText.text = coinCount.ToString();
    }
    public void oyunaBasla()
    {
        SceneManager.LoadScene(1);
    }
    public void oyundanCik()
    {
        SceneManager.LoadScene(0);
    }
}
