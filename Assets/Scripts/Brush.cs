using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Brush : MonoBehaviour
{
    [SerializeField] private float necessaryBrushingVelocity = 1.0f;

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.TryGetComponent(out ArtifactDirt dirt))
        {
            Debug.Log("Attempt Clean!");

            Rigidbody rb = GetComponent<Rigidbody>();
            if (math.abs(rb.velocity.magnitude) > necessaryBrushingVelocity)
            {
                Debug.Log("Cleaning!");
                dirt.Clean();
            }
        }
    }
}
