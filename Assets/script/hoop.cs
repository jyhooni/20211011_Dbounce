using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hoop : MonoBehaviour


{

    //public GameObject Pannel;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.5f, 1.5f);
        float y = Random.Range(-6.0f, -6.1f);

        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {//새로운 위치 = 현재위치 + 방향 * 속도 
        transform.position = transform.position + new Vector3(0, 1, 0) * Time.deltaTime;



	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");

        if(collision.transform.tag == "topwall")
        {
            Debug.Log("coll222");

            SceneManager.LoadScene("Gameover");
        }

    }


   // private void OnCollisionEnter2D(Collision2D coll2)
    //{
        
     //   Debug.Log("1111111111111");

       // Debug.Log(coll2.gameObject.tag);

       // if (coll2.gameObject.tag == "topwall")
        //{
//            Debug.Log("GAMEOVER");
  //      /
    //        SceneManager.LoadScene("Gameover");

            //Pannel.SetActive(true);
            //시간을 멈춰라
      //      Time.timeScale = 0.0f;
           // Destroy(gameover.gameObject);

       // }
   // }

    
}


     
