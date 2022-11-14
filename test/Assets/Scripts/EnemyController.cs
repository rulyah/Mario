using System;
using UnityEngine;

public class EnemyController : MonoBehaviour, ICollidable
{
    [SerializeField] private Player _player;
    public event Action<EnemyController, ICollidable> onUpperCollision;
    public event Action<EnemyController,ICollidable> onCollision;

    public void SetTarget(Player player)
    {
        _player = player;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var direction = Vector3.Normalize(transform.position - _player.transform.position);
            var player = collision.gameObject.GetComponent<Player>();
            if (direction.y < 0.0f)
            {
                onUpperCollision?.Invoke(this,player);
            }
            else
            {
                onCollision?.Invoke(this, player);
            }
        }
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        if (_player.isLive)
        {
            var direction = Vector3.Normalize(_player.transform.position - transform.position);
            transform.position += new Vector3(direction.x, 0.0f) * Time.deltaTime;
        }
    }
}