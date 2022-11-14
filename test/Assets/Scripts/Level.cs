using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    public Transform startPoint => _startPoint;
    
    [SerializeField] private FinishLvlPlace _finishLvlPlace;
    public FinishLvlPlace finishLvlPlace => _finishLvlPlace;

}