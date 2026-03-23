using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
	public void StartNewGame()
	{
		SaveData data = new SaveData();
		SaveSystem.Save(data);
		ContinueGame();
	}

	public void ContinueGame()
	{
		SceneManager.LoadScene(1);
	}

	public void Settings()
	{

	}

	public void Exit()
	{
		Application.Quit();
	}
}
