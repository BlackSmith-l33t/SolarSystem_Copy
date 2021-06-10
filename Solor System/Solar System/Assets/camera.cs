using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class camera : MonoBehaviour
{
    public AudioSource _Music;
    public AudioClip _Clip;
    private float volume;

    // Start is called before the first frame update
    void Start()
    {
        _Music = GetComponent<AudioSource>();
        _Music.Play();
        _Music.loop = true;
        _Music.PlayOneShot(_Clip, volume);
        _Music.volume = 0.2f;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            GetComponent<Camera>().transform.position = new Vector3(-133.0f, 160.0f, -216.0f);
            GetComponent<Camera>().transform.rotation = Quaternion.Euler(24, 11, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            GetComponent<Camera>().transform.position = new Vector3(-104.0f, 560.0f, 5.0f);
            GetComponent<Camera>().transform.rotation = Quaternion.Euler(90, 90, 90);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            GetComponent<Camera>().transform.position = new Vector3(-75.0f, 254.0f, -563.0f);
            GetComponent<Camera>().transform.rotation = Quaternion.Euler(16, 3, 0);
        }
    }
}
