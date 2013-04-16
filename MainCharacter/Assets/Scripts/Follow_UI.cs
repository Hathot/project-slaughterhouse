using UnityEngine;
using System.Collections;


public class Follow_UI : MonoBehaviour {
	int player = 1;

	void OnGUI()
	{
		
		GUILayout.Label("Character Movement");
		if (GUI.Button(new Rect(10, 70, 50, 30), "Click")) {
            if(player==1) {
				player=2;	
			}
			else {
				player=1;
			}
			
		}
		
		
	}
}
