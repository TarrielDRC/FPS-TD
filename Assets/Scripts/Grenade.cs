using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour {

	public float explodeTime = 0.0f;
	public float explodeRadius = 1.0f;
	public float effectScale = 1.0f;
	public GameObject effect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		explodeTime -= Time.deltaTime;
		Debug.Log (explodeTime);
		if (explodeTime < 0) {
			Detonate ();
		}
	}

	void Detonate() {
		effect.transform.localScale *= effectScale;
		effect.transform.position = this.gameObject.transform.position;
		Instantiate (effect);
		Destroy (this.gameObject);
	}
}
