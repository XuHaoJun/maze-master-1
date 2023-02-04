using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
	public float Speed = 8;

	public int NumKeys = 0;

	[SerializeField] private TextMeshProUGUI NumKeysUI;

	[SerializeField] private GameObject[] Players;

	[SerializeField] private AudioClip CatchItemAudioClip;

	// Start is called before the first frame update
	void Start()
	{
		Players = GameObject.FindGameObjectsWithTag("Player");
	}

	// Update is called once per frame
	void Update()
	{
		foreach (var player in Players)
		{
			if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
			{
				transform.position += player.transform.right * Time.deltaTime * Speed;
			}
			if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
			{
				transform.position -= player.transform.right * Time.deltaTime * Speed;
			}
			if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
			{
				transform.position += player.transform.forward * Time.deltaTime * Speed;
			}
			if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
			{
				transform.position -= player.transform.forward * Time.deltaTime * Speed;
			}
		}
	}

	public bool UseKeyItem()
	{
		if (NumKeys > 0)
		{
			NumKeys -= 1;
			NumKeysUI.text = NumKeys.ToString();
			return true;
		}
		else
		{
			return false;
		}
	}

	private void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Key")
		{
			NumKeys += 1;
			NumKeysUI.text = NumKeys.ToString();
			GetComponent<AudioSource>().PlayOneShot(CatchItemAudioClip);
			Destroy(other.gameObject);
		}
	}
}
