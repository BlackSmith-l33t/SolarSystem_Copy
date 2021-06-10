using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sun : MonoBehaviour
{
    public TextMesh sunText;
    public Behaviour halo; 
    public GameObject Light;
    public float RotateSpeed = 25.0f;  // 자전 주기 약 25일
    //public Camera m_Camera;



    // Start is called before the first frame update
    void Start()
    {
       
        Behaviour halo = (Behaviour)gameObject.GetComponent("Halo");
        halo.enabled = true;
        Light light = GameObject.Find("sunlight").GetComponent<Light>();
        //sunText = GetComponent<Text>();
        //sunText.text = ;

    }

    
    // Update is called once per frame
    void Update()
    {
        Destroy(sunText);
        transform.Rotate(Vector3.right * RotateSpeed * Time.deltaTime);
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            RotateSpeed = RotateSpeed + 5.0f;
            Debug.Log("Speed up");
            Debug.Log(RotateSpeed);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            RotateSpeed = RotateSpeed - 5.0f;
            Debug.Log("Speed Down");
            Debug.Log(RotateSpeed);

            if (RotateSpeed <= 0.0f)
            {
                RotateSpeed = 0.0f;
            }

        }
        else if (Input.GetKey(KeyCode.Tab))
        {
            RotateSpeed = 25.0f;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            RotateSpeed = 0.0f;
        }

        //transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward, m_Camera.transform.rotation * Vector3.up);
    }


}
