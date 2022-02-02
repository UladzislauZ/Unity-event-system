using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragImage : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Image _image;

    public void PotentialDrag()
    {
        _image.color = Color.red;
    }

    public void BeginDrag()
    {
        transform.localScale = Vector3.one * 1.3f;
    }

    public void Drag()
    {
        var pos = _camera.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0f;
        transform.position = pos;
    }

    public void EndDrag()
    {
        transform.localScale = Vector3.one;
    }

    public void Drop()
    {
        _image.color = Color.white;
    }
}
