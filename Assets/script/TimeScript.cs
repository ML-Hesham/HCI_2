using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
public class TimeScript : MonoBehaviour
{
    private Text T;
    private static float count = 10;
    public GameObject Finish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        T = GetComponent<Text>();
        count -= Time.deltaTime;
        T.text="Time Left : "+math.round(count);
        if (count <=0)
        {
            Finish.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
