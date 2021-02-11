using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 6f;

    [HideInInspector] public RivalSlider rivalSlider;
    public SliderControl sliderControl;
    [HideInInspector] public QuizManager quizManager;
    [HideInInspector] public Rakip rakip;
    [HideInInspector] public Player player;

    [SerializeField] TextMeshProUGUI countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        RakipSecim();

    }
    public void RakipSecim()
    {
        if (currentTime <= 0)
        {
            currentTime = 0;
            quizManager.Correct();
            //karşı oyuncu seçim yapacak
            rivalSlider.positivearttir();
            sliderControl.negativearttir();
            rakip.GetComponent<Animator>().SetBool("isVictory", true);
            player.GetComponent<Animator>().SetBool("isVictory", false);

            Sifirla();

        }
    }
    public void Sifirla()
    {
        currentTime = startingTime;
    }
}
