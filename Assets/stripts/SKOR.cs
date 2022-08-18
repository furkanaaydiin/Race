using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class SKOR : MonoBehaviour
{
     
public UnityEngine.UI.Text skor;
public   aracHareket   arabahareket;

    

    void Start()
    {
        
    }

    
    void Update()
    {
        skor.text = arabahareket.puan.ToString();
    }
}
