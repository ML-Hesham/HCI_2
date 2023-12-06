using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinscore : MonoBehaviour
{
    public static int scorevalue = 0;
    Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretext =  GetComponent<Text>();
        scoretext.text = "Score : "+ scorevalue;
    }
}
