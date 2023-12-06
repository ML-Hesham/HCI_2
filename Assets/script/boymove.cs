using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boymove : MonoBehaviour
{
    private Rigidbody2D reg;
    int speed = 40;
    int jump = 60;
    public AudioSource s1;

    //public GameObject sky;
    //public GameObject ground;
    //public GameObject mount;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        reg = GetComponent<Rigidbody2D>();
        int x = 0;
        int y = 0;
        if (Input.GetKey("right"))
        { x = speed;
            transform.localScale = new Vector3(4, 4, 1);
            //sky.transform.position=Vector3.left * speed *Time.deltaTime;
            //mount.transform.position = Vector3.left * speed * Time.deltaTime;
            //ground.transform.position = Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey("left"))
        { x = -speed;
            transform.localScale = new Vector3(-4, 4, 1);
            
            //sky.transform.position = Vector3.right * speed * Time.deltaTime;
            //mount.transform.position = Vector3.right * speed * Time.deltaTime;
            //ground.transform.position = Vector3.right* speed * Time.deltaTime;
        }
        else if (Input.GetKey("up"))
        { y = jump; }
        else
        { y = -jump; }
        reg.AddForce(new Vector2(x, y));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zombie")
        {
            Destroy(collision.gameObject);
            coinscore.scorevalue -= 10;
        }
        if (collision.gameObject.tag== "target")
        {
            Destroy(collision.gameObject);
            coinscore.scorevalue += 10;
        }
        if(collision.gameObject.tag == "door")
        {
            Application.LoadLevel("QuitScene");

            
        }
    }
}
