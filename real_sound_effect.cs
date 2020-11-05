using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class real_sound_effect : MonoBehaviour {

    private AudioSource my_audio_source;
    private float distance_from_main_character;
    private GameObject main_character;
    public string name_of_main_pj;

    // Use this for initialization
    void Start () {
        my_audio_source = gameObject.GetComponent<AudioSource>();
        main_character = GameObject.Find(name_of_main_pj);
        distance_from_main_character = Vector3.Distance(gameObject.transform.position, main_character.transform.position);
    }
	
	// Update is called once per frame
	void Update () {
        float new_vol = calcula_volumen(Vector3.Distance(gameObject.transform.position, main_character.transform.position));
        my_audio_source.volume = new_vol - .3f;

    }

    float calcula_volumen(float actual_distance)
    {
        float rdo = 0f;

        rdo = actual_distance * 1 / distance_from_main_character;
        //print(rdo);
        rdo = 10 - (rdo * 10);
        rdo = rdo / 10; //devuelve el valor de porcentaje del 0,1 al 0,9
        /*print(rdo);
        print("-------------");*/

        return rdo;
    }


}
