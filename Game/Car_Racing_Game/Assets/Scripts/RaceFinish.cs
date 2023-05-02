using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class RaceFinish : MonoBehaviour {

	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewModes;
	public GameObject LevelMusic;
	public GameObject CompleteTrig;
	public AudioSource FinishMusic;
    public GameObject gameover;


	void OnTriggerEnter () {
        if (ModeTime.isTimeMode == true)
        {
            //we are on race TIME mode
        }
        else
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MyCar.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            MyCar.GetComponent<CarController>().enabled = false;
            MyCar.GetComponent<CarUserControl>().enabled = false;
            MyCar.SetActive(true);
            gameover.SetActive(true);
            FinishCam.SetActive(true);
            LevelMusic.SetActive(false);
            ViewModes.SetActive(false);
            FinishMusic.Play();
            GlobalCash.TotalCash += 100;
            PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        }

	}
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        this.GetComponent<BoxCollider>().enabled = true;
        MyCar.SetActive(true);
        CompleteTrig.SetActive(true);
        CarController.m_Topspeed = 200;
        MyCar.GetComponent<CarController>().enabled = true;
        MyCar.GetComponent<CarUserControl>().enabled = true;
        MyCar.SetActive(false);
        gameover.SetActive(false);
        FinishCam.SetActive(false);
        LevelMusic.SetActive(true);
        ViewModes.SetActive(true);
        FinishMusic.Stop();
        ModeScore.CurrentScore = 0;
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(1);
        this.GetComponent<BoxCollider>().enabled = true;
        MyCar.SetActive(true);
        CompleteTrig.SetActive(true);
        CarController.m_Topspeed = 200;
        MyCar.GetComponent<CarController>().enabled = true;
        MyCar.GetComponent<CarUserControl>().enabled = true;
        MyCar.SetActive(false);
        gameover.SetActive(false);
        FinishCam.SetActive(false);
        LevelMusic.SetActive(true);
        ViewModes.SetActive(true);
        FinishMusic.Stop();
        ModeScore.CurrentScore = 0;
    }

}
