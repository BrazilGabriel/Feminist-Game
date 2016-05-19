using UnityEngine;

public class Obstacle : MonoBehaviour
{
	public Vector2 velocity = new Vector2(-3, 0);
	public float range = 3.5f;
	
	// Use this for initialization
	void Start()
	{
		GetComponent<Rigidbody2D>().velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	}
	void Update()
	{
		if (transform.position.x < -20){
			Destroy(gameObject);
		}
	}
}