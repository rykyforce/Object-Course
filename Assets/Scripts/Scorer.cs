using System;
using TMPro;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField]private int timesBumped;
    [SerializeField]private TMP_Text scoreText;

    private void Start()
    {
        timesBumped = 0;
        scoreText.text = timesBumped.ToString();
    }

    private void OnCollisionEnter(Collision other)
    {
        timesBumped++;
        scoreText.text = timesBumped.ToString();
    }
}
