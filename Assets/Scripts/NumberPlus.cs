using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberPlus : MonoBehaviour
{
    private Text Score;
    private int score;
    private int level;
    private int next;
    private int level2;
    private int next2;

    private float t1 = 1.0f;
    private float t2;

    private AudioSource audioSource;
    public AudioClip clickAudioClip;

    void Start()
    {
        Score = GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();

        score = 0;
        Score.text = score.ToString();
        level = 1;
        next = 12;
        level2 = 1;
        next2 = 51;
    }

    void Update()
    {
        if (level2 >= 2)
        {
            if (Time.time - t2 > 0)
            {
                score += level2;
                t2 = Time.time + t1;
                Score.text = score.ToString();
            }
        }
    }

    public void AddScore()
    {
        score += level;
        Score.text = score.ToString();

        audioSource.PlayOneShot(clickAudioClip, 1.0f);
    }

    public void AddClickLevel()
    {
        if (score >= next)
        {
            score -= next;
            Score.text = score.ToString();

            level += 1;
            next += 4;
        }
    }

    public void AddPassiveClick()
    {
        if (score >= next2)
        {
            score -= next2;
            Score.text = score.ToString();

            level2 += 1;
            next2 += 15;
        }
    }

    public void AddPoints1()
    {
        score += 1000;
        Score.text = score.ToString();
    }

    public void AddPoints2()
    {
        score += 6000;
        Score.text = score.ToString();
    }

    public void AddPoints3()
    {
        score += 13000;
        Score.text = score.ToString();
    }

    public void AddPoints4()
    {
        score += 30000;
        Score.text = score.ToString();
    }

    public void AddPoints5()
    {
        score += 64000;
        Score.text = score.ToString();
    }

    public void AddPoints6()
    {
        score += 100000;
        Score.text = score.ToString();
    }
}
