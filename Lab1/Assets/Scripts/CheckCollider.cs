using UnityEngine;

namespace Lab1
{
    public class CheckCollider : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log($"Sphere has collided with {other.name}");
            if (other.TryGetComponent<Renderer>(out var renderer))
            {
                renderer.material.SetColor("_Color", Color.green);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent<Renderer>(out var renderer))
            {
                renderer.material.SetColor("_Color", Color.red);
            }
        }
    }
}
