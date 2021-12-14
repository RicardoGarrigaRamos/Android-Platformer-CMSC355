using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public int noOfLevels;
    public GameObject levelButton;
    public RectTransform ParentPanel;

    private void Awake()
    {
        LevelButtons();
    }

    void LevelButtons()
    {
        if (PlayerPrefs.HasKey("level"))
        {
            int levelReached = PlayerPrefs.GetInt("level");
        }
        else
        {
            PlayerPrefs.SetInt("level", 1);
            LevelButtons();
        }

        for (int i =0; i < noOfLevels; i++)
        {
            GameObject lvlButton = Instantiate(levelButton);
            lvlButton.transform.SetParent(ParentPanel, false);
            Text buttonText = lvlButton.GetComponentInChildren<Text>();
            buttonText.text = (i + 1).ToString();
        }
    }
}
