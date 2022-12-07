using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private dialogTriggerOne trigger;
    [SerializeField] private GameObject dynamicLight;
    [SerializeField] private GameObject lightProbe;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (!dynamicLight.activeSelf)
            {
                dynamicLight.SetActive(true);
            }
            else
            {
                dynamicLight.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (!dynamicLight.activeSelf)
            {
                lightProbe.SetActive(true);
            }
            else
            {
                lightProbe.SetActive(false);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        trigger = other.GetComponent<dialogTriggerOne>();
        // Debug.Log("in range");
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("activate");
            trigger.TriggerDialog();
        }
    }
    
    
}

