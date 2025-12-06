using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFabs;
    public Transform bullet1Trash;
    public Transform bullet1Spawn;

    public GameObject prefabs; 
    public Transform bullet2Trash;
    public Transform bullet2Spawn;


    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;

    private void Update()
    {

        {
            TimerMethod();
            Shoot1();
            Shoot2();
        }


        {
            if (!_canShoot)
            {
                _currentTime -= Time.deltaTime;

                if (_currentTime < 0)
                {
                    _canShoot = true;
                    _currentTime = Timer;

                }

            }
        }
    }


    private void TimerMethod()
    {
        {
            if (!_canShoot)
            {
                _currentTime -= Time.deltaTime;

                if (_currentTime < 0)
                {
                    _canShoot = true;
                    _currentTime = Timer;

                }

            }

        }

    }

    private void Shoot1()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet1 = Instantiate(preFabs, bullet1Spawn.position, Quaternion.identity);

            bullet1.transform.SetParent(bullet1Trash);
        }
    }
    private void Shoot2()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {
            GameObject bullet2 = Instantiate(prefabs, bullet2Spawn.position, Quaternion.identity);

            bullet2.transform.SetParent(bullet2Trash);

        }

    }
} 