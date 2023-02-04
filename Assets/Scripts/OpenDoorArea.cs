using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorArea : MonoBehaviour
{
	public GameObject Door;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			var player = other.gameObject.GetComponent<Player>();
			var success = player.UseKeyItem();
			if (success)
			{
				Destroy(Door);
				var inGameMenuListern = GameObject.FindGameObjectWithTag("InGameMenuListern");
				var inGameMenu = inGameMenuListern.GetComponent<InGameMenu>();
				inGameMenu.Show();
			}
		}
	}
}
