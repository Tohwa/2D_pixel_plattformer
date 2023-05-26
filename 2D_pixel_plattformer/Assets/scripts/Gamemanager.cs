using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Events;

public class Gamemanager : MonoBehaviour
{
    #region Singleton
    private static Gamemanager _instance;

    public static Gamemanager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Gamemanger is null!");


            return _instance;
        }
    }


    private void Awake()
    {
        if (_instance)
            Destroy(gameObject);
        else
            _instance = this;

        DontDestroyOnLoad(this);
    }
    #endregion

    #region Fields
    Player_checks Player_Checks;
    GameObject Player;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
}
