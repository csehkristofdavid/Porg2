using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
	public GameObject Cursor;
	
	Vector3 LastPosition;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 CurrentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		CurrentPosition.z = 0;
		
		Cursor.transform.position = CurrentPosition;
		
        if(Input.GetMouseButton(1)){
			Vector3 diff = LastPosition - CurrentPosition;
			Camera.main.transform.Translate(diff);
		}
		LastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		LastPosition.z = 0;
	}
}
