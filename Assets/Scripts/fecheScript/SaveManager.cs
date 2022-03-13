using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    [SerializeField] ScoreList scorelist;
    string json;
    [Header("Variables UI")]
    [SerializeField] ScoreTextUI[] scoreTextList;
    [SerializeField] Transform panelScore;
    [SerializeField] GameObject[] textPrefab;

    public static SaveManager saveManager;
    public SaveManager()
    {
        saveManager = this;
    }

    private void Awake()
    {
        for (int i = 0; i < scoreTextList.Length; i++)
        {
            scoreTextList[i].textNameScore = textPrefab[i].transform.GetChild(0).GetComponent<Text>();
            scoreTextList[i].textScore = textPrefab[i].transform.GetChild(1).GetComponent<Text>();
        }
    }
    public void Save()// llamar cuando se necesita Guardar
    {
        json = JsonUtility.ToJson(scorelist);
        PlayerPrefs.SetString("a", json);
    }
    public void Load () // llamar cuando se necesita Cargar
    {
        json = PlayerPrefs.GetString("a", "/");
        scorelist = JsonUtility.FromJson<ScoreList>(json);
    }
    public void NewScore (string name, float score) // Agrega un nuevo Score
    {
        scorelist.scoresList.Add(new Score(name, score));
    }
    public void ShowScores () // Muestra el Score en la UI
    {
        for (int i = 0; i < scorelist.scoresList.Count; i++)
        {
            scoreTextList[i].textNameScore.text = scorelist.scoresList[i].nombre;
            scoreTextList[i].textScore.text = scorelist.scoresList[i].score.ToString();
            textPrefab[i].SetActive(true);
        }
    }
}
[System.Serializable]
public class ScoreTextUI
{
    public Text textNameScore;
    public Text textScore;
}

[System.Serializable]
public class ScoreList
{
   public List<Score> scoresList;
}
[System.Serializable]
public class Score
{
    public string nombre;
    public float score;

    public Score (string a, float b)
    {
        nombre = a;
        score = b;
    }

}
