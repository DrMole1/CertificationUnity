using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Mot-clef abstract signifie classe mère abstraite
public abstract class InputAction : ScriptableObject
{
    public string keyWord;

    //Signature de la fonction que l'on va utiliser dans les classes "filles"
    public abstract void RespondToInput(GameController controller, string[] separatedInputWords);
    


}
