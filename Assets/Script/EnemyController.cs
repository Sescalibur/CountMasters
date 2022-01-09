using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemy = 0;
    [SerializeField] TextMeshPro dusmanSayi;
    private bool control = true;
    // Start is called before the first frame update
    void Start()
    {
        enemy++;
    }

    // Update is called once per frame
    void Update()
    {
        //dusmanSayi.text = enemy.ToString();
    }

    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.tag == "Playertag")
    //    {
    //        Destroy(gameObject);
    //        Destroy(collision.gameObject);
    //    }
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Playertag"&&  control==true)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            enemy--;
            HaraketController.adamSayisi--;
            control = false;
        }
    }
}
