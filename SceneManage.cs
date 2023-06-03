using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void ChangeSceneByName(string name) {
        if (name != null){
            SceneManager.LoadScene(name);
        }
    }
}
