using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassiveButton : MonoBehaviour
{
    private Text passiveText;
    public Text NumberChanged;
    private int level;
    private int next;
    private int numberChanged;

    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        next = 51;
        passiveText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        numberChanged = int.Parse(NumberChanged.text);
    }

    public void AddPassive()
    {
        if (numberChanged >= next)
        {
            numberChanged -= next;
            NumberChanged.text = numberChanged.ToString();

            level += 1;
            next += 15;
            passiveText.text = "Click LV " + level + "\nNext: " + next;
        }

        else
        {
            Debug.Log("Not enough gold!");
        }
    }
}
