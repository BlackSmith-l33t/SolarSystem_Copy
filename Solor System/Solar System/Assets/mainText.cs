using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainText : MonoBehaviour
{

    public UnityEngine.UI.Text Text;
    // Start is called before the first frame update
    void Start()
    {
        Text.text = "Rotate, Revolution Speep up : UpArrow\n" +
            "Rotate, Revolution Speep down : DownArrow\n" +
            "Stop : Space\n" +
            "Restart : TAB\n" +
            "viewpoint(1) : Alpha1\n" +
            "viewpoint(2) : Alpha2\n" +
            "viewpoint(3) : Alpha3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
