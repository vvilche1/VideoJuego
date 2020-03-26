using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPlayer : MonoBehaviour
{
    public Transform seguido;
    public Vector3 vectorDiferencia;
    public Vector3 vectorDiferenciaAngulos;



    void Start()
    {
        vectorDiferencia = seguido.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = seguido.position - vectorDiferencia;
    }
}
