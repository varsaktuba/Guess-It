using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderControl : MonoBehaviour
{
    [HideInInspector] public Slider slider;
    public TextMeshProUGUI sliderText;
    [SerializeField]
    public TextMeshProUGUI gameOverText;
    private int gain = 10;
   

    // Start is called before the first frame update
    void Start()
    {
        slider.minValue = 0;
        slider.maxValue = 100;
       
        slider.wholeNumbers = false;

    }

   public void positivearttir()
    {
        slider.value += gain;
        sliderText.text = slider.value.ToString();
        
    }
    public void negativearttir()
    {
        slider.value -= gain / 2;
        sliderText.text = slider.value.ToString();
    }
   
    public void GameOver()
    {
        gameOverText.text = "Your Score: " + slider.value.ToString();
    }
}
