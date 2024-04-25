using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _objectToFollow;
    [SerializeField] private float _smoothSpeed = 4f;
    [SerializeField] private Vector3 _offset;

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _objectToFollow.position + _offset, Time.deltaTime * _smoothSpeed);
    }
}
