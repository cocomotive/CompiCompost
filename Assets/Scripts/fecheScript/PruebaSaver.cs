using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaSaver : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SaveManager.saveManager.NewScore("gholis",456);
            SaveManager.saveManager.Save();
            SaveManager.saveManager.Load();
            SaveManager.saveManager.ShowScores();
        }
        
    }
}
