using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockingCheck : MonoBehaviour
{
    public int collisionCount;
    public bool docked;
    // Start is called before the first frame update
    void Start()
    {
        docked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (collisionCount >= 5){
            Debug.Log("Vehicle Docked Succesfully");
            docked = true;
        }
    }

    void OnTriggerEnter(Collider coll){
        if (coll.tag == "Perimeter"){
            collisionCount++;
        }
    }

    void OnTriggerExit(Collider coll){
        if (coll.tag == "Perimeter"){
            collisionCount--;
        }
    }
}
