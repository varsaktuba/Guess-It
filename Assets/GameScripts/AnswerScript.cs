using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    [HideInInspector] public QuizManager quizManager;
    [HideInInspector] public SliderControl sliderControl;
    [HideInInspector] public Countdown countdown;
    [HideInInspector] public Player player;
    [HideInInspector] public Rakip rakip;
   


    public void Answer()
    {
        if (isCorrect)
        {
            sliderControl.positivearttir();
           
            quizManager.Correct();
            countdown.Sifirla();
            player.GetComponent<Animator>().SetBool("isVictory", true);
            rakip.GetComponent<Animator>().SetBool("isVictory", false);
          
            
        }
        else
        {
            sliderControl.negativearttir();
            
            quizManager.Correct();
            countdown.Sifirla();
            player.GetComponent<Animator>().SetBool("isVictory", false);
            rakip.GetComponent<Animator>().SetBool("isVictory", false);


        }
    }
}
