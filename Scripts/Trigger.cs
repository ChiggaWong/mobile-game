using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{

	public void Btn_change_scene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
