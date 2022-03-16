using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] bool IsMenuInGame;

    public Text RecordText;
    public GameObject Panel;

    private AsyncOperation _async;

    private void OnMouseDown()
    {
        
    }
    private void Update()
    {
        Exit();

        if (_async != null) 
        {
            if(!IsMenuInGame && _async.progress > 0.89f && Panel.GetComponent<Image>().color.a > 0.9f)
            {
                _async.allowSceneActivation = true;
            }
        }
        
    }
    private void Start()
    {
        if (!IsMenuInGame) 
        {
            RecordText.text = "BEST SCORE: " + Mathf.Round(PlayerPrefs.GetFloat("Record")).ToString();
            Time.timeScale = 1;
        }
        
    }

    private void Exit() 
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Application.Quit();
        }
    }
    public void InMenu() 
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame() 
    {
        SceneManager.LoadScene(1);
    }

    public void PLayNewGame() 
    {
        StartCoroutine(AsyncLoad());
    }

    IEnumerator AsyncLoad() 
    {
        StartCoroutine (ShowPanel());
        _async = SceneManager.LoadSceneAsync(1);
        _async.allowSceneActivation = false;

        yield return _async;
    }

    IEnumerator ShowPanel() 
    {
        Panel.SetActive(true);
        while (Panel.GetComponent<Image>().color.a < 1) 
        {
            Panel.GetComponent<Image>().color = new Color(0, 0, 0 ,Panel.GetComponent<Image>().color.a + 1 * Time.deltaTime * 2);

            yield return null;
        }
    }
}
