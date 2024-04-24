using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCame : MonoBehaviour
{
    public GameObject player; // Reference to the player object

    private void LateUpdate()
    {
        // Set the camera position to follow the player on the X-axis
        transform.position = new Vector3(player.transform.position.x, 4f, -10f);
    }
}
