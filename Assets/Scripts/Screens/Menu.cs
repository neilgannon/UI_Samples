using UnityEngine;

public class Menu : ScreenBase
{
    Animator menuAnimator;

    private void Awake()
    {
        menuAnimator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        menuAnimator.enabled = true;
        menuAnimator.Play("Show", -1, 0);
    }

    private void OnDisable()
    {
        menuAnimator.enabled = false;
    }
}
