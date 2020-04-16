using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
	float age = 0.0f;
	float age_Majeur = 18.0f;
	float age_Senior = 70.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
        	TestAge(age);
        	age += Time.deltaTime * 5.0f;
        }
    }

    void TestAge(float monAge)
    {
    	if (monAge > age_Senior)
    	{
    		print("Je suis vieux ! "+ monAge);
    	}
    	else if (monAge > age_Majeur)
    	{
    		print("Je suis majeur ! "+ monAge);
    	}
    	else
    	{
    		print("Je suis trop jeune ! "+ monAge);
    	}
    }
}
