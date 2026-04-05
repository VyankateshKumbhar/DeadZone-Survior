using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _timeToWaitBeforeExit;

    public void OnPlayerDied()
    {
        Invoke(nameof(EndGame), _timeToWaitBeforeExit);
    }

    private void EndGame()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
