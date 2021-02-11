using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rakip : MonoBehaviour
{
    Animator anim;

    public void VictoryIdle()
    {
        anim.SetBool("isVictory", true);
    }
}
