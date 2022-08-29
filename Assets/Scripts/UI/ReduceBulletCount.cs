using TMPro;
using UnityEngine;

public class ReduceBulletCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _bulletCount;
    private Cannon _cannon;

    private void Start()
    {
        _cannon = FindObjectOfType<Cannon>();
        GlobalEventManager.OnBulletFired += ReducedBullet;
    }
    private void OnDestroy()
    {
        GlobalEventManager.OnBulletFired -= ReducedBullet;
    }
    private void ReducedBullet()
    {
        _bulletCount.text = _cannon.BulletCount.ToString();
    }
}
