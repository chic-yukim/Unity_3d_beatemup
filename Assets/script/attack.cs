using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {
    public bool enemy_hit=false;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        if(other.gameObject.tag=="enemy")
        enemy_hit = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "enemy")
            enemy_hit = false;
    }
}
