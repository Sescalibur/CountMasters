using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject[] level;
    private bool kontrol = true;
    private bool levelKontrol = true;
    private static int seviye = 0;
    private bool sonkntrol = true;
    public GameObject Atananlevel;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        //AtananLevel[seviye] = new GameObject();
        //GameObject AtananLevel = Instantiate(level[seviye]) as GameObject;
        //Destroy(AtananLevel);
    }

    // Update is called once per frame
    void Update()
    {
        if (sonkntrol)
        {
            Atananlevel = (GameObject)Instantiate(level[seviye]);
            //Destroy(Atananlevel.gameObject);
            sonkntrol = false;
            levelKontrol = true;
        }
        //ilkLevel(Atananlevel);
        if (Input.anyKeyDown && kontrol == true)
        {
            Time.timeScale = 1;
            GameObject.FindGameObjectWithTag("Panel").active = false;
            kontrol = false;
            //Debug.Log("oldu mu");
        }
        //KayýpKontrol(Atananlevel);
        if (HaraketController.adamSayisi <= 0 && levelKontrol == true)
        {
            //Start();
            Destroy(Atananlevel.gameObject);
            //Atananlevel=Instantiate(level[seviye]);
            Time.timeScale = 0;
            levelKontrol = false;
            kontrol = true;
            sonkntrol = true;
        }

    }

    void KayýpKontrol(GameObject AtananLevel)
    {
        if (HaraketController.adamSayisi <= 0 && levelKontrol == true)
        {
            Destroy(AtananLevel.gameObject);
            //Instantiate(level[seviye]);
            Time.timeScale = 0;
            levelKontrol = false;
            kontrol = true;
        }
    }

    void ilkLevel(GameObject firstlevel)
    {
        if (sonkntrol)
        {
            firstlevel = Instantiate(level[seviye]);
            sonkntrol = false;
        }
        if (HaraketController.adamSayisi <= 0 && levelKontrol == true)
        {
            Debug.Log(HaraketController.adamSayisi);
            Destroy(firstlevel.gameObject);
            firstlevel=Instantiate(level[seviye]);
            Time.timeScale = 0;
            levelKontrol = false;
            kontrol = true;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Playertag" && levelKontrol == true)
        {
            Destroy(Atananlevel.gameObject);
            seviye++;
            //Instantiate(level[seviye]);
            levelKontrol = false;
            Time.timeScale = 0;
            sonkntrol = true;
            kontrol = true;
            HaraketController.adamSayisi = 0;
        }
    }
}
