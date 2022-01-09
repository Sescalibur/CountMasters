using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyMoInst : MonoBehaviour
{
    private int dusmanSayisi;
    [SerializeField] GameObject adam;
    [SerializeField] GameObject ada;

    private TextMeshPro sayi;
    // Start is called before the first frame update
    void Start()
    {
        //for (int i =0;i< transform.childCount;i++)
        //{
        //    if(transform.chil)
        //}

        foreach (Transform cocuk in transform)
        {
            //Debug.Log(cocuk.gameObject.tag);
            if (cocuk.gameObject.tag == "Enemy")
            {
                dusmanSayisi++;
            }
        }

        sayi = gameObject.GetComponentInChildren<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        sayi.text = dusmanSayisi.ToString();
        if (ada.transform.position.z - adam.transform.position.z < 5)
        {
            gameObject.transform.position= adam.transform.position;
        }   
    }
}
