using Unity.VisualScripting;
using UnityEngine;

public class FallMechanic : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private Rigidbody _rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.enabled = false;
    }

    public void Fall()
    {
        _meshRenderer.enabled = true;
        _rigidbody.useGravity = true;      
    }
}
