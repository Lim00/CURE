using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ClassCallBot : MonoBehaviour
{
    public GameObject botToCall;
    public GameObject[] calledBots;
    public Vector3 spawnAnchor;

    private float BOT_GAGE_MAX = 5.0f;
    private float botCallGage;

    public Button botCallButton;
    public Text botGageText;

    void Start()
    {
        // Reset spawn position and timer
        spawnAnchor.x = 0;
        spawnAnchor.y = 0;
        spawnAnchor.z = 0;

        botCallGage = 0.0f;

        botCallButton = GameObject.Find("Class1CallBot").GetComponent<Button>();
        // botGageText = botCallButton.GetComponentInChildren<Text>();
        botCallButton.onClick.AddListener(CallBot); // Add bot-calling functionality

        botGageText = GameObject.Find("CallingBotText").GetComponent<Text>(); // Find text component to print out the gage
        botGageText.text = botCallGage.ToString();
    }

    void Update()
    {
        botCallGage += 0.5f * Time.deltaTime;
        botCallGage = Mathf.Clamp(botCallGage, 0f, BOT_GAGE_MAX);

        botGageText.text = botCallGage.ToString("#.00") + " / 5";
    }



    public void CallBot()
    {
        Debug.Log(botCallGage.ToString());

        if (botCallGage >= BOT_GAGE_MAX)
        {
            Instantiate(botToCall, spawnAnchor, Quaternion.identity); // Call bot
            botCallGage = 0.0f; // Reset timer
        }
    }
}
