using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    GameObject MainCube;
    int yukseklik;
    void Start()
    {

        MainCube = GameObject.Find("MainCube");
        
    }

    // Update is called once per frame
    void Update()
    {
        MainCube.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0); 
    }

    public void yukseklikAzalt()
    {
        yukseklik--;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Topla" && other.gameObject.GetComponent<ToplanabilirCube>().GetToplandiMi() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<ToplanabilirCube>().toplandiYap();
            other.gameObject.GetComponent<ToplanabilirCube>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = MainCube.transform;
        }
;
    }


}
