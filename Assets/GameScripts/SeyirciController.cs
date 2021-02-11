using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeyirciController : MonoBehaviour
{

    [HideInInspector] public SliderControl sliderControl;
    [HideInInspector] public RivalSlider rivalSlider;
    int maxValue = 30;

    private void Update()
    {
        AnimationState();
    }
    public void AnimationState()
    {
        if (sliderControl.slider.value > rivalSlider.slider.value && sliderControl.slider.value > maxValue)
        {
            GetComponent<Animator>().SetBool("isCheering", true);
            
        }
        else
        {
            GetComponent<Animator>().SetBool("isCheering", false);
           
        }
       
        
    }
    
}
