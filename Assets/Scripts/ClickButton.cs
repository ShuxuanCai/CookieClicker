using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    private Text clickText;
    public Text NumberChanged;
    private int level;
    private int next;
    private int numberChanged;

    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        next = 12;
        clickText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        numberChanged = int.Parse(NumberChanged.text);      
    }

    public void AddIncreament()
    {
        if (numberChanged >= next)
        {
            numberChanged -= next;
            NumberChanged.text = numberChanged.ToString();

            level += 1;
            next += 4;
            clickText.text = "Click LV " + level + "\nNext: " + next;
        }

        else
        {
            Debug.Log("Not enough gold!");
        }
    }
}
