using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
	[SerializeField] private GameObject mob;

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
			mob.GetComponent<Animator>().SetTrigger("MeleeAttack");
		}
	}
}
