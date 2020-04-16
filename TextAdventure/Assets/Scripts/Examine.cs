using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputAction/Examine")]
public class Examine : InputAction
{
    //Mot-clef override signifie qu'il hérite de la méthode de la classe "mère"
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
    	controller.LogStringWithReturn (controller.TestVerbDictionaryWithNoun (controller.interactableItems.examineDictionary, separatedInputWords [0], separatedInputWords [1]));
    }
}
