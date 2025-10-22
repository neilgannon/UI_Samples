using RotaryHeart.Lib.SerializableDictionary;
using System;
using UnityEngine;

[Serializable]
public class ScreenDictionary: SerializableDictionaryBase<string, GameObject> { }

public class ScreenManager : MonoBehaviour
{
    [SerializeField]
    private ScreenDictionary Screens;

    [SerializeField]
    private string StartingScreen;

    private string ActiveScreen;

    private void Start()
    {
        DiableAllScreens();
        ShowScreen(StartingScreen);
    }

    public void ShowScreen(string screenName)
    {
        if (screenName == ActiveScreen)
            return;

        if (!Screens.ContainsKey(screenName))
            return;

        if (!string.IsNullOrEmpty(ActiveScreen))
        {
            Screens[ActiveScreen].SetActive(false);
        }

        ActiveScreen = screenName;
        Screens[ActiveScreen].SetActive(true);
    }

    private void DiableAllScreens()
    {
        foreach (var screen in Screens.Values)
        {
            screen.SetActive(false);
        }
    }

    /*
     * if you use CanvasGroup instead of GameObject for screens, you can implement fade in/out
     * I'd use the DOTween package for this fading.
     */ 
    private void FadeScreenIn(string screenName)
    {
    }

    private void FadeScreenOut(string screenName)
    {
    }
}
