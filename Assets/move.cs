using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour{
    public float speed;
    private Rigidbody rigid;
    public int vida = 100;
    public int puntos = 0;
   

    // Start is called before the first frame update
    void Start(){
        rigid = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void FixedUpdate(){

        float Horizontal = Input.GetAxis("Horizantal");
        float Veritical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(Horizontal, 0.0f , Veritical);

        rigid.AddForce(move * speed);

    }
}
