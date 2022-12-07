
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //components
    private Rigidbody _rigidbody;

    //Move smooth
    private Vector3 currVelocity;
    private float turnVelocity;

    //Move Factors
    [Range(1, 100)] [SerializeField] private float PlayerBaseSpeed;

    //Camera Reference
    [SerializeField] private Camera mainCamera;
    
    //Checks
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Debug.Log(_rigidbody.velocity);
    }

    private void Update()
    {

    }

    public void Move(Vector2 direction)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + mainCamera.transform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnVelocity, 0.1f) ;
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            //Move
            Vector3 camDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            if (direction.magnitude > 0.1f)
            {
                _rigidbody.velocity = Vector3.SmoothDamp(_rigidbody.velocity, camDirection * (PlayerBaseSpeed * direction.magnitude), ref currVelocity, 0.2f);
            }
            else
            {
                _rigidbody.velocity = Vector3.SmoothDamp(_rigidbody.velocity, Vector3.zero, ref currVelocity, 0.2f);
            }
        }
        
        

        // public void CameraControl(Vector2 direction)
        // {
        //     thridPersonCamera.m_XAxis.m_InputAxisValue = -direction.x;
        //     thridPersonCamera.m_YAxis.m_InputAxisValue = -direction.y;
        // }
        
    
    // private void OnDrawGizmos()
    // {
    //     Gizmos.DrawWireSphere(groundCheck.position, 0.1f);
    // }
}
