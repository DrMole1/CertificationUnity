using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Pour retrouver le scriptable objects directement lors de la création
[CreateAssetMenu(menuName = "TextAdventure/Room")]
public class Room : ScriptableObject
{
	[TextArea] //Pour permettre d'écrire (dans le moteur directement) beaucoup plus de textes
	public string description;
	public string roomName;
	public Exit[] exits;
	public InteractableObject[] interactableObjectsInRoom;
}
