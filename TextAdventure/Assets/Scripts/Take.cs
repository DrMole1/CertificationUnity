﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputAction/Take")]
public class Take : InputAction
{
    //Mot-clef override signifie qu'il hérite de la méthode de la classe "mère"
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
    	Dictionary<string,string> takeDictionary = controller.interactableItems.Take(separatedInputWords);

    	if(takeDictionary != null)
    	{
    		controller.LogStringWithReturn(controller.TestVerbDictionaryWithNoun(takeDictionary, separatedInputWords[0], separatedInputWords[1]));
    	}
    }
}
