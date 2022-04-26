using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController4 : MonoBehaviour
{
	private float speed = 6.0f;
	public GameObject character;

	public GameObject inventory;
	

	bool isInventory = false;

	void Update()
	{

	/*	if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}*/
	}
	public void ToggleInventory()
	{
		//when inventory is on time is paused and cursor is unlocked
		isInventory = !isInventory;
		if (isInventory)
		{
			inventory.SetActive(true);
		
			Time.timeScale = 0;
		
		}
		//when inventory is closed the game can be played and the cursor is locked
		else
		{
			inventory.SetActive(false);
			
			Time.timeScale = 1;
			
		}

	}
}


