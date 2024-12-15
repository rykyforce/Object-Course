using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10.0f;


    void Update()
    {
        InputToMovementTranslation();
    }

    void InputToMovementTranslation()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(new Vector3(xValue, 0 , zValue));
    }
}
