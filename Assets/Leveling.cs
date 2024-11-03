using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leveling : MonoBehaviour
{
	
	public int bLevel = 0;			//Starting level
	public int C_exp = 0;			//Holds the current amount of experience the player has before they can upgrade
	public int B_exp = 30;			//Starting amount to achieve your first upgrade
	public int R_exp = 30;			//Remaining amount necessary to get to the next upgrade
	public int M_exp = 100;			//Modifier to get to next upgrade
	public int L_cap = 2;			//Upgrade cap (for now)
	public int rate = 100;			//Increases the rate that resources are gathered.
	
    /*// Start is called before the first frame update
    void Update()
    {
    
    }*/
	
	public void ResourceExp(int a)
	{
		C_exp += a;
		
		if (C_exp >= R_exp)
		{
			BaseUpgrade();
		}
	}
	
	void BaseUpgrade()
	{
		C_exp -= R_exp;
		bLevel++;
		float tmp = Mathf.Pow(M_exp, bLevel);
		R_exp = (int)Mathf.Floor(B_exp * tmp);
	}
}
