using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject _shotPoint;
    [SerializeField] private GameObject[] _bullets;
    [SerializeField] private float _fireDelay = 0.2f;
    [SerializeField] private int _bulletCount;

    private Coroutine _fireFrequency;
    private int _idForBullet;
    private AudioSource _audioSource;

    public int BulletCount
    {
        get
        {
            return _bulletCount;
        }
    }

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    public void StartFire()
    {
        if (_bulletCount > 0)
            _fireFrequency = StartCoroutine(CreateBullet());
    }

    public void FinishFire()
    {
        if (_bulletCount > 0)
            StopCoroutine(_fireFrequency);
    }

    private IEnumerator CreateBullet()
    {
        while (true)
        {
            if (_bulletCount > 0)
            {
                int randomBullets = Random.Range(0, _bullets.Length);
                GameObject newBullet = Instantiate(_bullets[randomBullets], _shotPoint.transform.position, Quaternion.identity) as GameObject;
                Bullet bullet = newBullet.GetComponent<Bullet>();
                bullet.Shot(transform.right);
                bullet.id = _idForBullet;
                _idForBullet++;
                _bulletCount--;
                _audioSource.Play();
                GlobalEventManager.SendBulletFired();
            }
            yield return new WaitForSeconds(_fireDelay);
        }
    }
}
