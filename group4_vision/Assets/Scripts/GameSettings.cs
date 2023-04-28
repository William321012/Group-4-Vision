using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSettings : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] InputField username;
    // Start is called before the first frame update
    void Start()
    {
        if (username == null && SceneManager.GetActiveScene().name == "Main Menu") {
            username = GameObject.Find("Name").GetComponent<InputField>();
            username.text = PersistentData.Instance.GetName();
            AudioListener.volume = .5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        string name = username.text;
        PersistentData.Instance.SetName(name);
        SceneManager.LoadScene("Cutscene1");
    }

    public void GoToControls() {
        SceneManager.LoadScene("Controls");
    }

    public void GoToMain() {
        SceneManager.LoadScene("Main Menu");
    }

    public void ChangeVolume() {
        AudioListener.volume = volumeSlider.value;
    }
}
