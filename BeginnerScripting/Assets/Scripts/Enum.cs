using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{
	enum Direction{Nord,Sud,Est,Ouest};
    // Start is called before the first frame update
    void Start()
    {
        Direction maDirection = Direction.Sud;
        Reverse(maDirection);
    }

    Direction Reverse(Direction dir)
    {
    	if(dir == Direction.Nord)
    	{
    		dir = Direction.Sud;
    	}
    	else if(dir == Direction.Sud)
    	{
    		dir = Direction.Nord;
    	}
    	else if(dir == Direction.Est)
    	{
    		dir = Direction.Ouest;
    	}
    	else if(dir == Direction.Ouest)
    	{
    		dir = Direction.Est;
    	}

    	print("Ma direction est : " + dir);
    	return dir;
    }


}
