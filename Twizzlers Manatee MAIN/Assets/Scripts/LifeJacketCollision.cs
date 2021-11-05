using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///
/// Checks if “Player” tagged object collides with the life jacket.
/// If yes, destroy the life jacket.
/// 
/// @author Sami Cemek
/// Updated: 08/20/21
/// 
/// </summary>

public class LifeJacketCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") //if the object collides with player tagged object
        {
            Debug.Log("The player collided with a lifejacket");
            Destroy(this.transform.gameObject); //destroy that object
        }
    }
}
