using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int i = 0;

    public Text lbl;
    public TMP_Text lbl1;

    public void plus()
    {
        i+=1;
        lbl.text = ""+i;
        lbl1.text = ""+i;
    }

    void OnCollisionEnter(Collision collision) 
    {
        print(collision.gameObject.name);

        plus();
        //if (collision.gameObject.name == "Cube")
        //{
        //    Destroy(collision.gameObject);
        //}
    }




}
