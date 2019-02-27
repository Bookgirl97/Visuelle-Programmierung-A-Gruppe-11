using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelTransitions : MonoBehaviour {

	
	public Animator transitionAnim;
	public string sceneName;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	

public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
           StartCoroutine(LoadScene());
        }

    }	
	
	IEnumerator LoadScene(){
		transitionAnim.SetTrigger("fadend");
		yield return new WaitForSeconds(0.0f);
		SceneManager.LoadScene(sceneName);
	}
}
