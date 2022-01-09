using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Gecit : MonoBehaviour
{
    //[SerializeField] GameObject adam;
    //public static int adamSayisi;
    [SerializeField] TextMeshPro kullanma;
    private bool gectiMi = true;
    

    // Start is called before the first frame update
    void Start()
    {
        //string deneme=kullanma.GetComponent<TextMeshPro>().text;
        //char islem;
        //islem = deneme[0];
        //char[] sayi = new char[deneme.Length-1];
        //int k = 0;

        //for (int i = 1; i < deneme.Length; i++)
        //{
        //    sayi[k] = deneme[i];
        //    k+=1;
        //}
        //string sayilar = new string(sayi);
        //int kullan�lanSayi = Convert.ToInt32(sayilar);
        //bornPosition(kullan�lanSayi);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "Playertag"&&gectiMi==true)
        {
            //Debug.Log(gectiMi);
            //Destroy(GameObject.FindGameObjectWithTag("Ge�it").gameObject);
            //Debug.Log("Gerceklesti");
            Destroy(gameObject);
            bornPosition(collision.gameObject);
            gectiMi = false;
        }
    }

    private void bornPosition(GameObject adam)
    {
        string deneme = kullanma.GetComponent<TextMeshPro>().text;
        char islem;
        islem = deneme[0];
        char[] sayi = new char[3];
        int k = 0;

        for (int i = 1; i < deneme.Length; i++)
        {
            sayi[k] = deneme[i];
            k += 1;
        }
        string sayilar = new string(sayi);
        int kullan�lanSayi = Convert.ToInt32(sayilar);
        //Debug.Log(kullan�lanSayi);
        
        if (islem == '+')
        {
            Vector3[] pozisyon = new Vector3[kullan�lanSayi];
            for (int i = 0; i < kullan�lanSayi; i++)
            {
                
                if (kullan�lanSayi > 0 && kullan�lanSayi < 25)
                {
                    sikKullan(i, (float)0.25, pozisyon, adam);
                }
                else if (kullan�lanSayi > 25 && kullan�lanSayi < 50)
                {
                    sikKullan(i, (float)0.5, pozisyon, adam);
                }
                else if (kullan�lanSayi > 50 && kullan�lanSayi < 75)
                {
                    sikKullan(i, (float)0.75, pozisyon, adam);
                }
                else if (kullan�lanSayi > 75)
                {
                    sikKullan(i, (float)1, pozisyon, adam);
                }
            }
        }
        
        if(islem == 'x'|| islem == 'X')
        {
            int sinir= (kullan�lanSayi-1)*HaraketController.adamSayisi;
            Vector3[] pozisyon = new Vector3[sinir];
            //Debug.Log(sinir);
            for (int j = 0; j < sinir; j++)
            {
                if (kullan�lanSayi <= 2)
                {
                    sikKullan(j, (float)0.25,pozisyon, adam);
                    Debug.Log("Kullandim 1");
                }
                else if (kullan�lanSayi > 2 && kullan�lanSayi <= 5)
                {
                    sikKullan(j, (float)0.5, pozisyon, adam);
                    Debug.Log("Kullandim 2");
                }
                else if (kullan�lanSayi > 5 && kullan�lanSayi <= 8)
                {
                    sikKullan(j, (float)0.75, pozisyon, adam);
                    Debug.Log("Kullandim 3");
                }
                else if (kullan�lanSayi > 8)
                {
                    sikKullan(j, (float)1, pozisyon, adam);
                    Debug.Log("Kullandim 4");
                }
            }
        }
    }
    void sikKullan(int i, float derece,Vector3[] pozisyon,GameObject adam)
    {
        pozisyon[i] = new Vector3(adam.transform.position.x + Random.RandomRange(-derece, +derece), adam.transform.position.y, adam.transform.position.z + Random.RandomRange(-derece, +derece));
        GameObject adamlar = Instantiate(adam, pozisyon[i], Quaternion.identity) as GameObject;
        adamlar.transform.parent = adam.transform.parent;
        Debug.Log(pozisyon[i]);
    }
}
