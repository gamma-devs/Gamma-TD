using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public SortedList path2;
	//List<GoToPoint> path;
    // Start is called before the first frame update
    void Start()
    {
		//path = new List<GoToPoint>();
        var path = Object.FindObjectsOfType<GoToPoint>();
		//SortedList path2 = new SortedList();
		path2 = new SortedList();
		List<Vector3> coordinates = new List<Vector3>();
		foreach (GoToPoint point in path){
			path2.Add(point.OrderNumber, point.transform.position);
		}
		Debug.Log(path2);
		foreach(DictionaryEntry pair in path2){
			Debug.Log(pair.Key);
			Debug.Log(pair.Value);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
