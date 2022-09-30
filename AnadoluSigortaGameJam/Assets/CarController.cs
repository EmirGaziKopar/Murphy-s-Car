using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public TimeManager time;
    public  Animator Anim;
    public GameObject Meteor;
    public GameObject CarMotor;
    public HingeJoint2D hinge;
    public bool ulasti;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ulasti == true)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            Debug.Log("Calisti");
            Anim.SetTrigger("Meteor");
            Meteor.GetComponent<Rigidbody2D>().velocity = new Vector3(0,20000*Time.deltaTime,0);
            //Meteor.gameObject.GetComponent<BoxCollider2D>().enabled = false; çalýþmadý
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            time.slowMotionEffectCall();
            //collision.transform.GetChild(0).GetComponent<HingeJoint2D>().enabled = false;
            //hinge.breakTorque = 0;
            var motorDeger = 0f;
            ulasti = true;
            
            
            
           
        }
    }
    
}
