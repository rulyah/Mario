using UnityEngine;

public class Player : MonoBehaviour, ICollidable
{
    [SerializeField] private Rigidbody _rigidbody;
    private bool _isJump;
    private float _runSpeed;
    private int health = 3;

    public bool isLive = true;

    public void Jump()
    {
        if (!_isJump)
        {
            _isJump = true;
            _rigidbody.AddForce(new Vector3(0.0f, 350.0f));
        }
    }

    public void Move(float speed)
    {
        _runSpeed = speed;
    }


    private void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Plane"))
        {
            _isJump = false;
        }
    }

    public void TakeDamage()
    {
        health--;
        if (health <= 0) isLive = false;
    }

    private void Update()
    {
        var moveVector = new Vector3(_runSpeed, 0.0f);
        if (moveVector != Vector3.zero)
        {
            transform.forward = moveVector.normalized;
        }
        transform.position += moveVector * Time.deltaTime;
    }
    
}
