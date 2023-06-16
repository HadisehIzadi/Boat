using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Generator : MonoBehaviour
{
	public Wave WavePrefab;
    public Transform Pivot;
    public Transform ShootTransform;

   // private int _bulletsCount = 8;
    
    private void Update()
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0;
        var direction = (mouseWorldPosition - Pivot.position);
        Pivot.up = direction.normalized;

        if (Input.GetMouseButtonDown(0))
        {
           // if (EventSystem.current.IsPointerOverGameObject())
             //   return;
           // if (_bulletsCount <= 0)
             //   return;
            var bullet = Instantiate(WavePrefab, ShootTransform.position, Quaternion.identity);
            bullet.transform.up = ShootTransform.up;
            //_bulletsCount--;
            //FindObjectOfType<GameHUD>().UpdateBullets(_bulletsCount);

        }
    }
    /*
    [ContextMenu("Reload")]
    public void Reload()
    {
        _bulletsCount = 8;
        //FindObjectOfType<GameHUD>().UpdateBullets(_bulletsCount);
    }*/

}
