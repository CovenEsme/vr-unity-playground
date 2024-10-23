using UnityEngine;

public class ShovelDig : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out SoftDirt dirt)) {
            dirt.DoShovel();
        }
    }
}
