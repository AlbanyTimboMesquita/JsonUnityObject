using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Heroi _heroi = new Heroi();
        _heroi.nome="Xablau";
        _heroi.velocidade=7.8f;
        _heroi.dano=150;

       /*  //SAVE 
        string jsonsave = JsonUtility.ToJson(_heroi);
        PlayerPrefs.SetString("arquivo",jsonsave);
        print("SAVE :"+jsonsave); */

        //LOAD
        string jsonload = PlayerPrefs.GetString("arquivo");
        Heroi _heroiLoad =JsonUtility.FromJson<Heroi>(jsonload);
        print("*************");
        print(_heroiLoad.nome);
        print(_heroiLoad.velocidade);
        print(_heroiLoad.dano);

        
    }

    
}
