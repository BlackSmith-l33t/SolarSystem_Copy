using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public GameObject Earth;
    Sun sunScript;
    private float rotatespeed = 27.0f; // 태양 기준 
    private float _revolutionSpeed = 70.0f;
    LineRenderer _revolutionLine;
    Vector3[] _revolutionPos;
    // Start is called before the first frame update
    void Start()
    {
        
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
            rotatespeed = 27.0f;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            rotatespeed = 0.0f;
        }


    }

    void Orbit()
    {
        transform.RotateAround(Earth.transform.position, Vector3.down, _revolutionSpeed * Time.deltaTime);
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
            _revolutionSpeed = 70.0f;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            _revolutionSpeed = 0.0f;
        }


    }


    // Update is called once per frame
    void Update()
    {
        Rotate();

        Orbit();
       
    }
}
