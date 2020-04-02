using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	private SortedList path;
	private Vector3 target;
	private int targetTracker = 0;
	private Vector3 Velocity;
	private Vector3 Acceleration;
	//private Vector3 Velocity;
    // Start is called before the first frame update
    void Start()
    {
		EnemySpawner spawner = Object.FindObjectOfType<EnemySpawner>();
        path = spawner.path2;
		target = (Vector3)path[0];
		Debug.Log(target);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		
        if((target-transform.position).magnitude<0.1f && targetTracker<path.Count-1){
			target = (Vector3)path[targetTracker+1];
			targetTracker++;
			Acceleration = Vector3.zero;
			Velocity = Vector3.zero;
			
			
		}
		
		Vector3 force = (target-transform.position).normalized;
		accelerate(Time.fixedDeltaTime, force);
    }
	void accelerate(float deltaTime, Vector3 force){
		Acceleration = Vector3.zero;
		Acceleration += force;
		Velocity += deltaTime * Acceleration;
        transform.position +=  (0.5f * deltaTime * deltaTime * Acceleration + deltaTime * Velocity).normalized*0.03f;
	}
}
