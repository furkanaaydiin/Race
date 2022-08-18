using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aracHareket : MonoBehaviour
{
    bool oyunbitti = false;
    public int puan = 0;

    private Rigidbody rigidbodyComponent;
    AudioSource  AudioSource ;
    void Start()
    {
        puan = 0;
        rigidbodyComponent = GetComponent<Rigidbody>();
        AudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(Input.GetKey("d"))
        {
            rigidbodyComponent.AddForce(20,0,0 ,ForceMode.Force);
        }
        if(Input.GetKey("a"))
        {
            rigidbodyComponent.AddForce(-15,0,0,ForceMode.Force);
        }
        if(Input.GetKey("s"))
        {
            rigidbodyComponent.AddForce(0,0,-20,ForceMode.Force);
        }
        if(Input.GetKey("w"))
        {
            if ( oyunbitti == false)
        rigidbodyComponent.velocity = new Vector3(rigidbodyComponent.velocity.x,0,20 );
        else if (oyunbitti == true)
        rigidbodyComponent.velocity = Vector3.zero;
        }
        if(rigidbodyComponent.position.z > 480)
        {
            oyunbitti = true;
            rigidbodyComponent.velocity = Vector3.zero;
            Invoke("restart", 2f);
        }
        
        
    }
    
    private void OnCollisionEnter(Collision Collision )
    {
         if (Collision.collider.tag == "engel")
         {
            Invoke("restart", 3f);
            oyunbitti = true;
            AudioSource.Play();

         }
         if ( Collision.collider.tag == "coin")
         {
            puan++;
            Destroy(Collision.gameObject);
           
         }
    }

private void restart()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
oyunbitti =false;
}




         
}
