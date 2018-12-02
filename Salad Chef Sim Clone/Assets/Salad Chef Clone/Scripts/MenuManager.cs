using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    public GameObject loadingScreen;
    public Slider loadingBarSlider;

    //TO DO: Passing LevelIndex to load character selection and power upgrade scene in future.
    public void LoadLevel(int levelIndex)
    {
        StartCoroutine(Progress(levelIndex));
    }

    IEnumerator Progress(int index)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);
        loadingScreen.SetActive(true);
        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            loadingBarSlider.value = progress;
            yield return null;
        }
    }
}
