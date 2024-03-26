using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class gamemanager : MonoBehaviour
{

    [Header("Global Vars")]
    public GameObject Player3D;
    public float timer;

    [Header("UI/UX Vars")]
    public TextMeshProUGUI timetext;

    public enum GameState
    {
        START, PLAYING, END
    };

    public GameState myGameState;

    // Start is called before the first frame update
    void Start()
    {
        myGameState = GameState.START;
        Player3D.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
