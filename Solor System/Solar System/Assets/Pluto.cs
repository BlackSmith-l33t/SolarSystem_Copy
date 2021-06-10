using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluto : MonoBehaviour
{
    public GameObject Sun;
    Sun sunScript;
    public TextMesh plutoText;
    private float rotatespeed = 6.0f;
    private float _revolutionSpeed = 5.0f;
    int _orbitTail;
    LineRenderer _revolutionLine;
    Vector3[] _revolutionPos;
    private Color c1 = Color.yellow;
    private Color c2 = new Color(248, 216, 8);

    // Start is called before the first frame update
    void Start()
    {
        _orbitTail = 5100;
        _revolutionPos = new Vector3[_orbitTail];
        _revolutionLine = GetComponent<LineRenderer>();
        _revolutionLine.startWidth = 0.3f;
        _revolutionLine.endWidth = 1.0f;
        _revolutionLine.startColor = c1;
        _revolutionLine.endColor = c1;
        _revolutionLine.positionCount = _orbitTail;
        //_revolutionLine.material = new Material()


        for (int i = 0; i < _orbitTail; i++)
        {
            _revolutionPos[i] = transform.position;
        }
        _revolutionLine.SetPositions(_revolutionPos);

      

    }

    void updateTail()
    {
        for (int i = 1; i < _orbitTail; i++)
        {
            _revolutionPos[i - 1] = _revolutionPos[i];
        }
        _revolutionPos[_orbitTail - 1] = transform.position;
        _revolutionLine.SetPositions(_revolutionPos);
    }

    void Rotate()
    {
        transform.Rotate(Vector3.right * rotatespeed * Time.deltaTime);
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rotatespeed = rotatespeed + 5.0f;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rotatespeed = rotatespeed - 5.0f;

            sunScript = GameObject.Find("Sun").GetComponent<Sun>();
            if (sunScript.RotateSpeed == 0.0f)
            {
                rotatespeed = 0.0f;
            }
        }
        else if (Input.GetKey(KeyCode.Tab))
        {
            rotatespeed = 6.0f;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            rotatespeed = 0.0f;
        }
    
    }


    void Orbit()
    {
        transform.RotateAround(Sun.transform.position, Vector3.down, _revolutionSpeed * Time.deltaTime);
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            _revolutionSpeed = _revolutionSpeed + 5.0f;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _revolutionSpeed = _revolutionSpeed - 5.0f;
            if (_revolutionSpeed < 0.0f)
            {
                _revolutionSpeed = 0.0f;
            }
        }
        else if (Input.GetKey(KeyCode.Tab))
        {
            _revolutionSpeed = 5.0f;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            _revolutionSpeed = 0.0f;
        }


    }


    // Update is called once per frame
    void Update()
    {
        Destroy(plutoText);

        Rotate();

        Orbit();

        updateTail();
    }
}
