using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanabilirCube : MonoBehaviour
{
    bool toplandimi;
    int index; //toplama pozisyonu

    public Toplayici toplayici;

    void Start()
    {
        toplandimi = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (toplandimi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Engel"))
        {
            print("Carpýsýyor");
            toplayici.yukseklikAzalt();
            transform.parent = null; //parenttan çýkartýyoruz ki orada kalsýn.
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false; //objenin collidingini kapatma
        }
    }

    public bool GetToplandiMi()
    {
      return toplandimi;
    }

    public void toplandiYap()
    {
        toplandimi = true;
    }

    public void IndexAyarla(int index)
    {
        this.index = index;
    }


}
