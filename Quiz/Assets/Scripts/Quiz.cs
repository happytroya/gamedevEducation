using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuizSO question;
    [SerializeField] GameObject[] answerButtons;
    [SerializeField] Sprite correctAnserSprite;
    [SerializeField] Sprite incorrectAnserSprite;
    TextMeshProUGUI buttonText;
    Image buttonImage;

    void Start()
    {
        GetNextQuestion();
    }

    public void OnAnswerSelected(int index)


    {
        if(index == question.GetCorrectAnswerIndex())
        {
            questionText.text = "Correct";
            buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnserSprite;
        }
        else
        {
            questionText.text = "Incorrect";
            buttonImage = answerButtons[question.GetCorrectAnswerIndex()].GetComponent<Image>();
            buttonImage.sprite = correctAnserSprite;
        }

        SetButtonState(false);
    }

    void GetNextQuestion()
    {
        SetButtonState(true);

        DisplayQuestion();
    }

    void DisplayQuestion()
    {
        questionText.text = question.GetQuestion();

        for(int i = 0; i < answerButtons.Length; i++)
        {
            buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

    void SetButtonState(bool state)
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            Button answerButton = answerButtons[i].GetComponent<Button>();
            answerButton.interactable = state;
        }
    }

    void SetDefaultButtonsSprite()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            buttonImage = answerButtons[i].GetComponent<Image>();
            buttonImage.sprite = incorrectAnserSprite;
        }
    }
}
