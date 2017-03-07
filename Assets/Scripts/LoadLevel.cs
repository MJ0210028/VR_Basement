using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadLevel : MonoBehaviour {

    public void loadnewLevel(int level)
    {
        SceneManager.LoadScene(0);
    }
}
