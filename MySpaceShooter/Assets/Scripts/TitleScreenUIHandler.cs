using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreenUIHandler : MonoBehaviour
{
    [SerializeField] private GameObject howToPlayDialog;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject settingDialog;
    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
    public void HowToPlay()
    {
        howToPlayDialog.SetActive(true);
    }
    public void CloseHowToPlay()
    {
        animator.SetTrigger("Close");
        StartCoroutine(WaitForCloseDialog());
    }

    IEnumerator WaitForCloseDialog()
    {
        yield return new WaitForSeconds(0.5f);
        howToPlayDialog.SetActive(false);
    }
}
