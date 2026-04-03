using TMPro;
using UnityEngine;

public class NameInput : MonoBehaviour
{
    [SerializeField] private TMP_InputField m_InputField;
	[SerializeField] private GameObject Error;
	[SerializeField] private MenuLogic m_MenuLogic;

	private void Awake()
	{
		m_InputField.onSubmit.AddListener(SetName);
		Error.SetActive(false);
	}

	public void SetName(string name)
	{
		SetName();
	}

	public void SetName()
	{
		string placeholder = m_InputField.text;

		if (string.IsNullOrEmpty(placeholder))
		{
			Error.SetActive(true);
			return;
		}

		PlayerPrefs.SetString("PlayerName",placeholder);
		m_MenuLogic.ContinueGame();
	}

}
