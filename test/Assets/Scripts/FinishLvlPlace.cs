using System;
using UnityEngine;

public class FinishLvlPlace : MonoBehaviour
{
    [SerializeField] private GameObject _finishPlace;

    public event Action onFinishPlaceEnter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            onFinishPlaceEnter?.Invoke();
        }
    }
}