using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class QuizManager : MonoBehaviour
{
    public List<QnA> QnA;
    public GameObject[] options;
    public int currentQuestion;
    [HideInInspector] public GameControl gameControl;
    [HideInInspector] public SliderControl sc;
    [HideInInspector] public RivalSlider rs;
    public ParticleSystem confetti1;
    public ParticleSystem confetti2;
    private bool played;

    public TextMeshProUGUI QuestionTxt;

    void Start()
    {
        
        GenerateQuestion();
    }
    void Update()
    {
        if(QnA.Count == 0 && sc.slider.value > rs.slider.value)
        {
            StartCoroutine(Win());
        }
        if(QnA.Count == 0 && sc.slider.value < rs.slider.value)
        {
            StartCoroutine(Lost());
            Time.timeScale = 1f;
        }
    }
    IEnumerator Win()
    {
        if (!played)
        {
            confetti1.Play();
            confetti2.Play();
            played = true;
        }
            yield return new WaitForSeconds(2f);
        
            gameControl.WinGame();
    }
    IEnumerator Lost()
    {
        yield return new WaitForSeconds(1.5f);
        gameControl.EndGame();
    }

    public void Correct()
    {
        QnA.RemoveAt(currentQuestion);
        GenerateQuestion();
       
    }
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    void GenerateQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);
        QuestionTxt.text = QnA[currentQuestion].Question;
        SetAnswers();
 
    }
}
