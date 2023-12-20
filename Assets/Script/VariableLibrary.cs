using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableLibrary : MonoBehaviour
{

    public Dictionary<string, int> IDToLevelDictionary;

    public static VariableLibrary instance;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            IDToLevelDictionary = new Dictionary<string, int>();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int GetLevel(string s)
    {
        if(IDToLevelDictionary.ContainsKey(s))
        {
            return IDToLevelDictionary[s];
        }
        else
        {
            return 0;
        }

    }

    public void RegisterLevel(string s, int level)
    {
        if(IDToLevelDictionary.ContainsKey(s))
        {
            IDToLevelDictionary[s] = level;
        }
        else
        {
            IDToLevelDictionary.Add(s, level);
        }
    }
}
