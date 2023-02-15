using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]
    private float cSpeed;
    [SerializeField]
    private float cSpeedMove;
    GameObject Plane;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * cSpeedMove * Time.deltaTime;

        this.transform.Translate(yatayEksen, 0, cSpeed * Time.deltaTime);
        
    }
}
