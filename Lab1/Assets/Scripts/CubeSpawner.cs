using TMPro;
using UnityEngine;

namespace Lab1
{
    public class CubeSpawner : MonoBehaviour
    {
        [SerializeField] private TMP_InputField inputField;
        [SerializeField] private GameObject cubePrefab;
        [SerializeField] private float cubeSpawnDistance;

        private void Start()
        {
            inputField.onEndEdit.AddListener((text) =>
            {
                var cubeCount = int.Parse(text);
                for (var i = 0; i < cubeCount; i++)
                {
                    Instantiate(cubePrefab, cubeSpawnDistance * i * Vector3.up, new Quaternion());
                }
            });
        }
    }
}
