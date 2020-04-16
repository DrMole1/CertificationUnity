using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAccess : MonoBehaviour
{

	//initialisation
	public int alpha  = 5;

	private int beta = 0;
	private int gamma = 3;

	private AnotherClass AutreClasse;
    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;
        AutreClasse = new AnotherClass();
        AutreClasse.FruitMachine(alpha, AutreClasse.banane);
    }

    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    // Update is called once per frame
    //void Update()
    //{
    //    Debug.Log("Alpha = " + alpha);
    //}
}
