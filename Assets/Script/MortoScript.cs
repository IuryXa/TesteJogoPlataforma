using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MortoScript : MonoBehaviour
{
    public InimigoBehavior InimigoBehavior; // Reference to the player object

    private void OnTriggerEnter(Collider ColidiuPe)
    {
        if (ColidiuPe.gameObject.name == "PesPlayer")
        {
            InimigoBehavior.Morreu();
        }
    }
}
