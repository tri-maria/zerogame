/*
 * GameOverUIControls.cs 
 * Joshua Eagles - 301078033
 * Last Modified: 2022-03-04
 * 
 * Handles the logic for the controls on the game over screen
 *
 * Revision History:
 * 2022-02-13 - Initial Creation
 * 2022-03-04 - Unlock cursor when entering this scene
 * 2022-03-20 - Clear load game flag before retrying
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUIControls : MonoBehaviour
{
	public void Start()
	{
		Cursor.lockState = CursorLockMode.None;
	}

	public void OnRetryButton_Pressed()
	{
		PlayerPrefs.SetInt("LoadSavedGame", 0);
		SceneManager.LoadScene("Gameplay");
	}

	public void OnExitToMenuButton_Pressed()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
