using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class principal : MonoBehaviour
{

    public Text latitudText;
    public Text longitudText;
    

    void Start()
    {
        StartCoroutine("GetMap");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private IEnumerator GetMap()
    {
        Input.location.Start();
        float latitud = Input.location.lastData.latitude;
        latitudText.text = "" + latitud;

        yield return latitud;
        float longitud = Input.location.lastData.longitude;
        longitudText.text = "" + longitud;

        yield return longitud;

    }
}
