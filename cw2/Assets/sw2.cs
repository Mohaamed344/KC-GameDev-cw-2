using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sw2 : MonoBehaviour
{   
    string heroName = "superMan";
    float heroHeight = 1.86f;
    int heroAge =17;
    string herosuperpowr = "powered gun";

        
    string villianName = "poly";
    float villianHeight =1.89f;
    int villianAge = 31;
    string villianSuperpower = "super speed";

    // Start is called before the first frame update
    void Start()
    {
        int Agedifference = heroAge - villianAge;

        print(" the hero's name is " + heroName + "his age is " + heroAge);
        print("his height is " + heroHeight + "and his superpower is " + herosuperpowr);

        print("the villians name is " + villianName + " his age is " + villianSuperpower);
        print("his height is " + villianHeight + " and his superpower is " + villianSuperpower);

        print(" and the age differenec between the hero and villian is " + Agedifference);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
