using UnityEngine;
using System.Collections;

public class PlayerRespawn1 : MonoBehaviour
{
	//A reference to the game manager
	public GameManager1 gameManager; 

	// Triggers when the player enters the water
	void OnTriggerEnter(Collider other)
	{
		// Moves the player to the spawn point
		gameManager.PositionPlayer();
	}
}
