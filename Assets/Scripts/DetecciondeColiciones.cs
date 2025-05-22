using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecciondeColiciones : MonoBehaviour

{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Contacto");
        if (col.gameObject.name == "Player") 
        {
            Destroy(gameObject);
        }
      
    }
}