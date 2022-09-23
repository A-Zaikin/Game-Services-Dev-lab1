using UnityEngine;

namespace Lab1
{
    public class AddTorque : MonoBehaviour
    {
        [SerializeField] private float speed;

        private void Start()
        {
            var rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddRelativeTorque(Vector3.forward * speed);
        }
    }
}
