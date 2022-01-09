using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AdamSayisi : MonoBehaviour
{
    private Vector2 beginPosition, finishPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMeshPro>().text = HaraketController.adamSayisi.ToString();

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            beginPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            finishPosition = Input.GetTouch(0).position;
            if ((beginPosition - finishPosition).x < 0 && transform.position.x < 8.5)
            {
                transform.position = new Vector3(transform.position.x + 5f * Time.deltaTime, transform.position.y, transform.position.z);
            }

            if ((beginPosition - finishPosition).x > 0 && transform.position.x > -8.5)
            {
                transform.position = new Vector3(transform.position.x - 5f * Time.deltaTime, transform.position.y, transform.position.z);
            }
        }


        if (Input.anyKey)
        {
            if (Input.mousePosition.x < Screen.width / 2 && transform.position.x > -8.5)
            {
                transform.position = new Vector3(transform.position.x - 5f * Time.deltaTime, transform.position.y, transform.position.z);
            }
            if (Input.mousePosition.x > Screen.width / 2 && transform.position.x < 8.5)
            {
                transform.position = new Vector3(transform.position.x + 5f * Time.deltaTime, transform.position.y, transform.position.z);
            }
        }
    }
}
