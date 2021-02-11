using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
  

    public void VictoryAnim()
    {
        anim.SetBool("isVictory", true);
    }
}
