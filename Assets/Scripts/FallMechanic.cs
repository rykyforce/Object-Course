using Unity.VisualScripting;
using UnityEngine;

public class FallMechanic : MonoBehaviour
{
    [SerializeField] float timeToFall = 5;
    private Rigidbody _rigidBody;
    private MeshRenderer _meshRenderer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToFall)
        {
            _meshRenderer.enabled = true;
            _rigidBody.useGravity = true;
        }

    }
}
