using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        // TODO: ������� ������� �� ����� � ���������� ����� �� ����� ����� � ������� ����
        Application.Quit();
        Debug.Log("Exit pressed!");
    }

    public void TrackEditor()
    {
        // TODO: ������� ������� �� ����� ��������� ������
        //SceneManager.LoadScene("TrackEditor");
    }

    public void Records()
    {
        // TODO: ������� ������� �� ����� ��������
        //SceneManager.LoadScene("Records");
    }

}
