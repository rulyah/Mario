using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Player _player;

    private void Update()
    {
        transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, transform.position.z);
    }
}