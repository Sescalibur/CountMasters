using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class HaraketController : MonoBehaviour
{
    public static int adamSayisi=0;
    //[SerializeField] Camera cam;

    private bool gectiMi = true;
    // Start is called before the first frame update
    private Vector2 beginPosition, finishPosition;
    void Awake()
    {
        adamSayisi++;
        //Debug.Log(adamSayisi);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            beginPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            finishPosition = Input.GetTouch(0).position;
            if ((beginPosition - finishPosition).x < 0 && transform.position.x < 8.5)
            {
                transform.position = new Vector3(transform.position.x + 5f * Time.deltaTime, transform.position.y , transform.position.z);
            }

            if ((beginPosition - finishPosition).x > 0 && transform.position.x > -8.5)
            {
                transform.position = new Vector3(transform.position.x - 5f * Time.deltaTime, transform.position.y , transform.position.z);
            }
        }


        if (Input.anyKey)
        {
            if (Input.mousePosition.x < Screen.width/2&&transform.position.x>-8.5)
            {
                transform.position=new Vector3(transform.position.x-5f*Time.deltaTime,transform.position.y ,transform.position.z);
            }
            if (Input.mousePosition.x > Screen.width / 2 && transform.position.x < 8.5)
            { transform.position = new Vector3(transform.position.x + 5f * Time.deltaTime, transform.position.y ,transform.position.z);
            }
        }

        //float koþmaHizi = Time.deltaTime * 5f;
        //transform.Translate(0,0,koþmaHizi);
        //cam.transform.Translate(0,0,koþmaHizi);
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
            adamSayisi--;
        }
    }
}
