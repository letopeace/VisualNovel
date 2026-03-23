using System.IO;
using UnityEngine;

public static class SaveSystem
{
	public static string path = Application.persistentDataPath + "/save.json";

	public static void Save()
	{
		SaveData saveData = new SaveData();
		Save(saveData);
	}

	public static void Save(SaveData data)
	{
		string json = JsonUtility.ToJson(data, true);
		File.WriteAllText(path, json);
	}

	public static SaveData Load()
	{
		if (!File.Exists(path))
		{
			Debug.Log("Сохранения нет.");
			return new SaveData();
		}

		string json = File.ReadAllText(path);
		return JsonUtility.FromJson<SaveData>(json);
	}

}