using UnityEngine;

public interface ICollidable
{
    public Transform transform { get; }
    public GameObject gameObject { get; }
}