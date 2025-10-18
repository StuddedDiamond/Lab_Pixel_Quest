using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public GameObject SnipeShot;
    public Transform BulletTrash;
    public Transform BulletSpam;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;

    private void Update()
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;

            if (_currentTime < 0 )
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }



        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet = Instantiate(preFab, BulletSpam.position, Quaternion.identity);
            bullet.transform.SetParent(BulletTrash);
            _canShoot = false;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {
            GameObject SniperBullet = Instantiate(SnipeShot, BulletSpam.position, Quaternion.identity);
            BulletSpam.transform.SetParent(BulletTrash);
            _canShoot=false;
        }
    }
}
