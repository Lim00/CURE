using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainCharacterCallClass : MonoBehaviour
{
    // Classes call by user(each class attack differently or fix main character)
    public GameObject unitClass1;
    public GameObject unitClass2;
    public GameObject unitClass3;
    public GameObject unitClass4;

    // Button for each Class
    public Button unitClasss1Button;
    public Button unitClasss2Button;
    public Button unitClasss3Button;
    public Button unitClasss4Button;

    private void Start()
    {
        unitClasss1Button = GameObject.Find("Class1CallButton").GetComponent<Button>();
    }

    public void ButtonClass1()
    {
        Vector2 pos = transform.position;
        pos.x -= 6;
        Instantiate(unitClass1, pos, Quaternion.identity);

        unitClasss1Button.interactable = false; // Turn-off whence the button pushed
    }

    public void ButtonClass2()
    {
        Vector2 pos = transform.position;
        pos.x -= 3;
        Instantiate(unitClass2, pos, Quaternion.identity);

        unitClasss1Button.interactable = false;
    }

    public void ButtonClass3()
    {
        Vector2 pos = transform.position;
        pos.x += 3;
        Instantiate(unitClass3, pos, Quaternion.identity);

        unitClasss1Button.interactable = false;
    }

    public void ButtonClass4()
    {
        Vector2 pos = transform.position;
        pos.x += 6;
        Instantiate(unitClass4, pos, Quaternion.identity);

        unitClasss1Button.interactable = false;
    }
}
