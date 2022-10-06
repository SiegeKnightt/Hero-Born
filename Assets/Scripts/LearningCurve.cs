using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int currentAge = 30;
    public int addedAge = 1;

    public double PI = 3.14;
    public string firstName = "Harrison";
    public bool isAuthor = true;
    public int currentGold = 32;


    // Start is called before the first frame update
    void Start()
    {

        Dictionary<string, int> itemInventory = new Dictionary<string, int>() {

            {"Potion", 5},
            {"Sword", 7},
            {"Aspirin", 10}
        };

        List<string> questPartyMembers = new List<string>() {

            "Grim the Barbarian",
            "Dad",
            "Sterling the Knight"
        };

        Debug.LogFormat("Party members - {0}", questPartyMembers.Count);
        Thievery();
        computeAge();

        int characterLevel = 32;
        int nextSkillLevel = generateCharacter("Spike", characterLevel);

        Debug.Log(nextSkillLevel);
        Debug.Log(generateCharacter("Faye", characterLevel));

        // $ lets variables be directly inserted
        Debug.Log($"A string can have variables like {firstName} inserted directly!");
    }

    // Computes a modified age integer
    void computeAge() {

        Debug.Log(currentAge + addedAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int generateCharacter(string name, int level) {

        Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        return level += 5;
    }

    public void Thievery() {

        if (currentGold > 50) {

            Debug.Log("You're rolling in it!");
        }
        else if (currentGold < 15) {

            Debug.Log("Not much there to steal....");
        }
        else {

            Debug.Log("Looks like your purse is in the sweet spot!");
        }
    }
}
