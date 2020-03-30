﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;

    //Jonin testiä
    public GameObject questPanel;

    public PlayerController playerController;
    
    //public GameObject questWindows;
    public Text titleText;
    public Text descriptionText;
    public Text experienceText;
    public Text moneyText;

    public void OpenQuestWindow() {
        //questWindows.SetActive(true);
        titleText.text = quest.title;
        descriptionText.text = quest.description;
        experienceText.text = quest.experienceReward.ToString();
        moneyText.text = quest.moneyReward.ToString();
    }
    
    public void AcceptQuest() {
        //questWindows.SetActive(false);
        quest.isActive = true;
        playerController.quest = quest;

        //Jonin testiä
        playerController.SwitchStateAndMovement(playerController.menuPanel);
        playerController.questPanel.SetActive(true);
        titleText.text = quest.title;
        descriptionText.text = quest.description;

        //Text playerTitleText = playerController.questPanel.transform.GetChild(0).GetComponent<Text>();
        //Debug.Log(playerTitleText.text);
        //playerTitleText.text = titleText.text;
        //Debug.Log(playerTitleText.text);
        //Debug.Log(titleText.text);
        //Text playerDescriptionText = playerController.questPanel.transform.GetChild(1).GetComponent<Text>();
        //playerDescriptionText = descriptionText;
    }
}
