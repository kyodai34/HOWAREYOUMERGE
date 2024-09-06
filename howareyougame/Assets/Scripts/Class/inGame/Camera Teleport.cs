using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTeleport : MonoBehaviour
{
    [SerializeField] private GameObject position; 
    

    public void teleport()
    {
        this.transform.position = position.transform.position;
        this.transform.rotation = position.transform.rotation;

    }
}
