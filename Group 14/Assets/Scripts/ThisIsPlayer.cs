using UnityEngine;

public class ThisIsPlayer : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private Camera _camera;

    private Vector3 _moveDirection;

    private void Awake()
    {
        _camera.transform.parent.SetParent(null);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _moveDirection += Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _moveDirection -= Vector3.forward;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _moveDirection += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _moveDirection -= Vector3.right;
        }

        _moveDirection = Quaternion.Euler(0f, _camera.transform.localRotation.y, 0f) * _moveDirection;
        _moveDirection.Normalize();
    }

    private void FixedUpdate()
    {
        transform.Translate(_speed * Time.deltaTime * _moveDirection);
    }
}
