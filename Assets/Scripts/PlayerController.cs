/* 
* Created by: Omar Balfaqih (@OBalfaqih)
* http://obalfaqih.com
*
* Player Movement using Animator | Unity
*
* This script is for a tutorial on using Animator to create the player's movement
*
* Full tutorial available at:
* https://www.youtube.com/watch?v=LofJMnWPClo&index=2&list=PLaqp5z-4pFi5auiUbsq_KChZKX-DufAOI
*/

/*
* How to use:
* 1- Attach this script to the player
* 2- Assign the the player's Animator component to the "anim" variable
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Reference to the Animator component of the player
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        // Link the "vertical" parameter in the animator to the player's vertical input
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        // Link the "horizontal" parameter in the animator to the player's horizontal input
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
    }
}
