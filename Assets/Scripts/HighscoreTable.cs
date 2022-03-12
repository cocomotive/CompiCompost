using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    //private List<HighscoreEntry> highscoreEntryList;
    private List<Transform> highscoreEntryTransformList;

    private void Awake()
    {
        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        AddHighscoreEntry(5333340, "ISI");

        /*highscoreEntryList = new List<HighscoreEntry>()
        {
        new HighscoreEntry{score = 654321, name = "SKJ"},
        new HighscoreEntry{score = 3736, name = "DFT"},
        new HighscoreEntry{score = 25467, name = "ERY"},
        new HighscoreEntry{score = 634581, name = "ERT"},
        new HighscoreEntry{score = 45621, name = "dhh"},
        new HighscoreEntry{score = 3, name = "bdr"},
        new HighscoreEntry{score = 3624578, name = "sdf"},
        new HighscoreEntry{score = 64561, name = "DEH"},
        };*/



        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

       for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
            {
                if (highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
                {
                    HighscoreEntry tmp = highscores.highscoreEntryList[i];
                    highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                    highscores.highscoreEntryList[j] = tmp;
                }
            }
        }
        
        
        highscoreEntryTransformList = new List<Transform>();

        //foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
        //{
        //    CreateHighscoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
        //}


        for (int i = 0; i < 10; i++)
        {
            CreateHighscoreEntryTransform(highscores.highscoreEntryList[i], entryContainer, highscoreEntryTransformList);
        }

        /*Highscores highscores = new Highscores { highscoreEntryList = highscoreEntryList };
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("highscoreTable"));
        */
          

    }



    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {

        float templateHeight = 55f;

        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count + 1;
        string rankString;

        switch (rank)
        {
            default:
                rankString = rank + "°"; break;

            case 1: rankString = "1°"; break;
            case 2: rankString = "2°"; break;
            case 3: rankString = "3°"; break;
        }

        entryTransform.Find("positionT").GetComponent<Text>().text = rankString;
        int score = highscoreEntry.score;
        entryTransform.Find("scoreT").GetComponent<Text>().text = score.ToString();
        string name = highscoreEntry.name;
        entryTransform.Find("playerNameT").GetComponent<Text>().text = name;

        transformList.Add(entryTransform);

    }

    
    private void AddHighscoreEntry(int score, string name)
    {
        //crear la entrada de puntaje alto
        HighscoreEntry highscoreEntry = new HighscoreEntry { score = score, name = name };
        
        //carga puntajes mas altos
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
       
        //crea una nueva entrada de puntaje alto
        //highscores.highscoreEntryList.Add(highscoreEntry);
       
        //guarda nuevos puntajes actualizados
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
    }
    
    private class Highscores 
    {
        public List<HighscoreEntry> highscoreEntryList;
    }


    [System.Serializable]
    private class HighscoreEntry
    {
        public int score;
        public string name;
    }


}
