using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour{

    public int vida = 100;
    public int puntos = 0;
    public float velocidad = 1f;
    [Range(10f, 30f)]
    public float fuerzaSalto;


    //public float speed;
    //private Rigidbody rigid;
    //public int vida = 100;
    //public int puntos = 0;


    // Start is called before the first frame update
    void Start(){
       // rigid = GetComponent<Rigidbody>();   
    }

    //// Update is called once per frame
    //void Update(){

    //    float Horizontal = Input.GetAxis("Horizantal");
    //    float Veritical = Input.GetAxis("Vertical");

    //    Vector3 move = new Vector3(Horizontal, 0.0f , Veritical);

    //    rigid.AddForce(move * speed);

    //}

    // Update is called once per frame
    void Update()
    {
        if (this.vida > 0)
            this.GetComponent<Rigidbody>().AddForce(new Vector3(velocidad * Input.GetAxis("Horizontal"), (Input.GetButtonDown("Jump") && esNivelSuelo == true ? fuerzaSalto * 15 : 0f), velocidad * Input.GetAxis("Vertical")));
    }

    public bool esNivelSuelo = true;




    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            Debug.Log("CHOCANDO CON SUELO");
            esNivelSuelo = true;
        }
        else if (collision.gameObject.tag != "suelo")
        {
            Debug.Log("NO ENCUENTRO EL SUELO!");
            esNivelSuelo = false;
        }

        if (collision.gameObject.tag == "lava")
        {
            Debug.Log("Quemandome en la lava");
                esNivelSuelo = true;
            //if (this.vida > 0) {
            //    this.vida -= collision.gameObject.GetComponent<Lava>().daño;
            //}

        } else if (collision.gameObject.tag != "lava")
        {
            Debug.Log("Quemandome en la lava");
            esNivelSuelo = false;

        }
    }

    
    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.tag == "suelo")
    //    {
    //        Debug.Log("DEJE DE CHOCHAR CON SUELO");
    //        esNivelSuelo = false;
    //    }
    //}

}
