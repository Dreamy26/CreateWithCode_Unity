using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // LateUpadate is used to update after the update happens, making the camera move after vehicle
    void LateUpdate()
    {
        // Camera's position assigned to player's position
        // Offset the camera behind the player by adding new Vector to the player's position 
        transform.position = player.transform.position + offset;
    }
}
