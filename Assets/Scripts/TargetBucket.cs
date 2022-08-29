using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetBucket : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    [SerializeField]
    private int _amountBulletForWin;
    
    private int _finishedBullet;
    private List<Bullet> _ballsAtBucket;
    private Cannon _cannon;

    private void Awake()
    {
        _cannon = FindObjectOfType<Cannon>();
        _ballsAtBucket = new List<Bullet>(_cannon.BulletCount);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Bullet enterBullet;
        if (other.gameObject.TryGetComponent(out enterBullet))
        {
            for (int i = 0; i < _ballsAtBucket.Count; i++)
            {
                if (enterBullet.id == _ballsAtBucket[i].id)
                {
                    return;
                }
            }
            _ballsAtBucket.Add(enterBullet);
            _finishedBullet++;
            _scoreText.text = _finishedBullet + "/" + _amountBulletForWin;
        }
        if (_finishedBullet == _amountBulletForWin)
            GlobalEventManager.SendGameWin();
        if (_cannon.BulletCount == 0 && _finishedBullet < _amountBulletForWin)
            GlobalEventManager.SendGameLose();
    }
}
