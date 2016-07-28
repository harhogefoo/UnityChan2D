using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using DG.Tweening;


public class MainMenuBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClickedQuitButton()
	{
		// Application.Quit;
	}

	public void OnClickedStartButton()
	{
		DOTween.Init (false, true, LogBehaviour.ErrorsOnly);
		RectTransform rectTrans = GetComponent<RectTransform> ();
		rectTrans.DOMove (new Vector3 (-1000, 0, 0), 1.0f).OnComplete (() => {
			SceneManager.LoadScene ("UnityChanScene");
		});
	}
}
