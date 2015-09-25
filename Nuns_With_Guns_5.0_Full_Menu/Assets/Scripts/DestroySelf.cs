using UnityEngine;
using System.Collections;

public class DestroySelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("DestroyYourself", 1.0f);
	}

	void DestroyYourself()
	{
		Destroy(gameObject);
	}
}
