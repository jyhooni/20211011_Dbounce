using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene3 : MonoBehaviour
{
    public Text HStext;
    public Text HCtext;
    public Text SCtext;

    // Start is called before the first frame update
    void Start()

    {

       
    }

    // Update is called once per frame
    void Update()
    {
        HStext.text = "BEST:" + PlayerPrefs.GetInt("HighScore");
        HCtext.text = "" + PlayerPrefs.GetInt("HighCoin");
        SCtext.text = "" + PlayerPrefs.GetInt("Score");
    }

    public void retry()
    {

        GameManager.I.retry();

    }

}
