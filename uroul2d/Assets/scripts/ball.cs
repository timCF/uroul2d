using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public GameObject center;

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 vector = (transform.position - center.transform.position).normalized;
		GetComponent<Rigidbody2D>().AddForce((new Vector2(vector.y, (-1 * vector.x))));
	}
}
