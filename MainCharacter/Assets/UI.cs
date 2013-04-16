using UnityEngine;
using UnityEngine;
using System.Collections;


public class UI : MonoBehaviour {
	int player = 1;

	void OnGUI()
	{
		
		GUILayout.Label("	Character Movement Test");
		GUILayout.Label("	Controls:");
		GUILayout.Label(" 		Player 1:");
		GUILayout.Label(" 			Movement: WASD");
		GUILayout.Label(" 			Jump: Space Bar (Dive effect atm)");
		GUILayout.Label(" 			Double Jump: 2x Space Bar (Slow motion effect atm)");
		GUILayout.Label(" 			Crowl: left Control (Walk Effect atm)");
		GUILayout.Label(" 			Sprint: Shift ( speed x 1.2 )");
		GUILayout.Label(" 		Player 2:");
		GUILayout.Label(" 			Movement: Arrow keys");
		GUILayout.Label(" 			Hit: ',' Key ( wave effect atm )");
		
	}
}
