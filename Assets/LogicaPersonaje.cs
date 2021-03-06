using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocidad = 5.0f;
    public float rotacion = 200.0f;

    public Animator anim;

    public float x,y ;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0,x*Time.deltaTime*rotacion,0);
        transform.Translate(0,0,y*Time.deltaTime*velocidad);

        anim.SetFloat("velx",x);
        anim.SetFloat("vely",y);
    }
}
