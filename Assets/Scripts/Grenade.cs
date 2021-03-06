using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour {

	public float explodeTime = 600;
	public float explodeRadius = 1.0f;
	public float effectScale = 1.0f;
	public GameObject effect;

	void FixedUpdate() {
		explodeTime -= 1;
		//Debug.Log (explodeTime);
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
