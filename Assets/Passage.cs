using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passage : MonoBehaviour
{
    public Transform connection;

    private void Start() { }


    private void OnTriggerEnter(Collider other)
    {
            //check if other is pacman
            //if its pacman, find the character controller component 
            //assign character controllercomponent to a temporary variable

            //tell the controller component to move to the desired position

            Debug.Log(other.name);
        Vector3 position = other.transform.position;
        position.x = this.connection.position.x;
        position.y = this.connection.position.y;
        other.transform.position = position;
    }
    

}
