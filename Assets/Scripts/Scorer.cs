using TMPro;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int timesBumped;
    [SerializeField] TMP_Text scoreText;

    private void Start()
    {
        timesBumped = 0;
        scoreText.text = timesBumped.ToString();
    }
    public void UpdateTimesBumped()
    {
        timesBumped++;
        scoreText.text = timesBumped.ToString();
    }
}