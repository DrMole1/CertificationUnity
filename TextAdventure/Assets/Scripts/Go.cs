using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputAction/Go")]
//Extends de la classe InputAction
public class Go : InputAction
{
	//Mot-clef override signifie qu'il hérite de la méthode de la classe "mère"
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
    	controller.roomNavigation.AttemptToChangeRooms(separatedInputWords[1]);
    }
}
