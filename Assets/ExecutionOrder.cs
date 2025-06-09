using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionOrder : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake");
    }
    void Start()
    {
        Debug.Log("Start");
    }
    void Update()
    {
        Debug.Log("Update");
    }
    void FixedUdapte()
    {
        Debug.Log("FixedUdapte");
    }
    void OnEnable()
    {
        Debug.Log("OnEnable");
    }
}
