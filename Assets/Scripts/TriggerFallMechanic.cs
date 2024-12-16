using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFallMechanic : MonoBehaviour
{
    [SerializeField] FallMechanic fallMechanic;

    float _opacityController;
    private bool _wasTriggered;
    private Material _material;
    private Color _referenceColor; 
    
    public bool WasTriggered()
    {
        return _wasTriggered;
    }
    private void Start()
    {
        _material = GetComponent<Renderer>().material;
        SetOpacityInMaterial(0f);
        _wasTriggered = false;
        _opacityController = _material.color.a;
    }
    private void Update()
    {
        SetOpacityInMaterial(_opacityController);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_wasTriggered)
        {
            return;
        }
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(TriggerFlickerAnimation(0.3f,5));
            _wasTriggered = true; 
        }
    }
    void SetOpacityInMaterial(float opacity)
    {
        _referenceColor = _material.color;
        _referenceColor.a = opacity;
        _material.color = _referenceColor;  
    } 

    IEnumerator TriggerFlickerAnimation(float secondsToWait, int totalCount)
    {
        bool canBeDestroyed = false;
        bool isTransparent = true;
        int count = 0;
        while (canBeDestroyed == false)
        {
            if (count >= totalCount)
            {
                canBeDestroyed = true;
            }
            if (isTransparent)
            {
                _opacityController = 0.1f;
                count++;
                isTransparent = false;
                yield return new WaitForSeconds(secondsToWait);
            }else
            {
                _opacityController = 0f;
                count++;
                isTransparent = true;
                yield return new WaitForSeconds(secondsToWait);
            }    
        }
        fallMechanic.Fall();
        Destroy();
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
