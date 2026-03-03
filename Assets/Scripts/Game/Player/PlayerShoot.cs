using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerShoot : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject _bulletPrefab;

    [SerializeField]
    private float _bulletSpeed;

    [SerializeField]
    private Transform _gunOffset;

    private bool _fireSingle;

    [SerializeField]
    private float _timeBetweenShots;

    private float _lastFireTime;

    private bool _fireContinuously;

    // Update is called once per frame
    void Update()
    {
        if(_fireContinuously||_fireSingle )
        {
            float timeSinceLastFire = Time.time - _lastFireTime;
            if (timeSinceLastFire >= _timeBetweenShots)
            {
                FireBullet();
                _lastFireTime = Time.time;
                _fireSingle = false;
            }
        }
    }

    private void OnFire(InputValue inputValue)
    {

        _fireContinuously = inputValue.isPressed;
       if(inputValue.isPressed)
        {
            _fireSingle = true ;
        }

    }
    private void FireBullet()
    {
        GameObject bullet = Instantiate(_bulletPrefab,_gunOffset.position,transform.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();

        rigidbody.velocity = transform.up * _bulletSpeed;
    }
}
