using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaIntroController : MonoBehaviour {

    public Text hudRecord;

	// Use this for initialization
	void Start () {

        MostraRecord();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MostraRecord()
    {
        if (PlayerPrefs.HasKey("RECORDE"))
            hudRecord.text = string.Format("RECORDE: {0}", PlayerPrefs.GetInt("RECORDE"));
        else
            hudRecord.text = "RECORD: NÃO HÁ RECORDES";
    }

    public void LimpaRecorde()
    {
        if (PlayerPrefs.HasKey("RECORDE"))
        {
            PlayerPrefs.DeleteKey("RECORDE");
            hudRecord.text = "RECORDE: NÃO HÁ RECORDES";
        }
    }
}
