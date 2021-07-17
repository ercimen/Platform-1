using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [Header("---UI---")]
    [SerializeField] GameObject Start_UI;
    [SerializeField] GameObject Level_UI;
    [SerializeField] GameObject Lose_UI;
    [SerializeField] GameObject NextLevel_UI;

    [Header("---DISTANCE BAR---")]
    [SerializeField] Transform Player;
    [SerializeField] Transform Finish;
    [SerializeField] Slider FillBar;
    float PlayerZ, FinishZ,firstDistance;

    [Header("---OTHERS---")]
    [SerializeField] int Level;
    [SerializeField] Text ScoreText,LevelText;

    private bool click;
    public bool isLevelStarted;
    private int Score;
    

    #region Singleton

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<GameManager>();
            return _instance;
        }
    }
    #endregion
    private void Awake()
    {
        isLevelStarted = false;

    }

    private void Update()
    {
        DistanceBar();
    }
    private void Start()
    {
        PlayerZ = Player.position.z;
        FinishZ = Finish.position.z;
        firstDistance = FinishZ - PlayerZ;
    }

    public void StartGame()
    {
        isLevelStarted = true;
        Level_UI.SetActive(true);
        Start_UI.SetActive(false);
    }

    public void PauseForUI() => isLevelStarted = false;
    public void ScorePlus(int _Score) => Score += _Score;

    public void GameOver()
    {
        Level_UI.SetActive(false);
        Lose_UI.SetActive(true);
       // PauseForUI();
    }
    public void NextLevelPanel()
    {
        Level_UI.SetActive(false);
        NextLevel_UI.SetActive(true);
        // PauseForUI();
    }
    public void NextLevetbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void DistanceBar()
    {

        PlayerZ = Player.position.z;

        FillBar.value = 1 - ((FinishZ - PlayerZ) / firstDistance);

        if (FillBar.value ==1)
        {
            NextLevelPanel();
        }
    }
 
}
