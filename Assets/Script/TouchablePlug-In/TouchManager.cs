using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{

    public bool debug;
    private Camera _mainCamera;
    private Collider _collider;
    private ITouchable _iTouchable;
    void Start()
    {
        _mainCamera = Camera.main;
    }

    public int tc;

    void Update()
    {

        tc = Input.touchCount;

        if(Input.touchCount<=0)
        {
            ChangeITouchable(null);
            return;
        }


        var touchePos = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, _mainCamera.farClipPlane);
        var touchPosOrigin = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, _mainCamera.nearClipPlane);
        var touchePosInWorld = _mainCamera.ScreenToWorldPoint(touchePos);
        var touchePosInWorldOrigin = _mainCamera.ScreenToWorldPoint(touchPosOrigin);

        if (debug)
        {
            Debug.DrawLine(touchePosInWorldOrigin, touchePosInWorld, Color.red);
        }

        if (Physics.Raycast(touchePosInWorldOrigin, touchePosInWorld - touchePosInWorldOrigin, out var info))
        {
            var touchePosNear = _mainCamera.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, _mainCamera.nearClipPlane+10));
            if(info.collider != _collider)
            {
                _collider = info.collider;
                ChangeITouchable( info.collider.GetComponent<ITouchable>());

                _iTouchable?.OnTouchedDown(touchePosNear);
            }
            _iTouchable?.OnTouchedStay(touchePosNear);

        }
        else
        {
            ChangeITouchable(null);
        }
    }

    private void ChangeITouchable(ITouchable newValue)
    {
        if(_iTouchable==newValue)
        {
            return;
        }
        _iTouchable?.OnTouchedUp();
        _iTouchable = newValue;
        if(newValue == null)
        {
            _collider = null;
        }
    }
}
