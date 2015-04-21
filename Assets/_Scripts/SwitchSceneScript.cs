using UnityEngine;
using System.Collections;

public class SwitchSceneScript : MonoBehaviour {

    static int currentLevel;

	void OnTriggerEnter(Collider other)
    {
        
        Application.LoadLevel(currentLevel++);
    }
}
