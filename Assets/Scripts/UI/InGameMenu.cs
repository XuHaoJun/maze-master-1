using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
	public GameObject InGameMenuRoot;

	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("escape"))
		{
			ToogleMenu();
		}
	}

	public void HandleReplayClick()
	{
		SceneManager.LoadScene("MazeScene");
	}


	public void HandleQuitGameClick()
	{
		Application.Quit();
	}

	public void HandleBackToTitleClick()
	{
		SceneManager.LoadScene("StartMenuScene");
	}

	public void Show()
	{
		ToogleMenu(true);
	}

	public void Hide()
	{
		ToogleMenu(false);
	}

	public void ToogleMenu(bool? forceShow = null)
	{
		bool nextActive;
		if (forceShow != null)
		{
			nextActive = forceShow.Value;
		}
		else
		{
			nextActive = !InGameMenuRoot.activeSelf;
		}

		InGameMenuRoot.SetActive(nextActive);
		if (nextActive)
		{
			Cursor.lockState = CursorLockMode.None;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

}
