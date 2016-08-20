using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
public class DrawLine : MonoBehaviour
{
    [SerializeField]
    private LineRenderer _line;

    private bool _isPressed;
    public List<Vector3> ListPoints;
    private Vector3 _touchPos;

    void Awake()
    {
        _line.SetVertexCount(0);
        _line.SetWidth(0.1f, 0.1f);
        _isPressed = false;
        ListPoints = new List<Vector3>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isPressed = true;
            _line.SetVertexCount(0);
            ListPoints.RemoveRange(0, ListPoints.Count);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _isPressed = false;
        }

        if (_isPressed)
        {
            _touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (EventSystem.current.IsPointerOverGameObject())
            {
                Debug.Log("left-click over a GUI element!");
                ListPoints.RemoveRange(0, ListPoints.Count);
                _isPressed = false;
            }

            _touchPos.z = 0;
            if (!ListPoints.Contains(_touchPos))
            {
                ListPoints.Add(_touchPos);
                _line.SetVertexCount(ListPoints.Count);
                _line.SetPosition(ListPoints.Count - 1, ListPoints[ListPoints.Count - 1]);
            }
        }
    }
}


    //private bool checkPoints(Vector3 pointA, Vector3 pointB)
    //{
    //    return (pointA.x == pointB.x && pointA.y == pointB.y);
    //}  

