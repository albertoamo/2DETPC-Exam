using DG.Tweening;
using UnityEngine;

public class TweenPlatform : MonoBehaviour
{
    public Transform waypoint1;
    public Transform waypoint2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlatformMove();
    }

    void PlatformMove()
    {
        transform.DOMove(waypoint2.position, 5f).SetEase(Ease.Linear).OnComplete(() =>
        {
            transform.DOMove(waypoint1.position, 5f).SetEase(Ease.Linear).OnComplete(() =>
            {
                PlatformMove();
            });
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
