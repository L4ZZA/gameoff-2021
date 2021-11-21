using UnityEngine;

namespace Jammers
{
    public class ContinuosRotation : MonoBehaviour
    {
        [SerializeField] Vector3 axis = Vector3.up;
        [SerializeField] float speed;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(axis, Time.deltaTime * speed);
        }
    }
}