using UnityEngine;
using System.Collections;

public class GenerateObstacles : MonoBehaviour {

    public Transform cube;

	// Use this for initialization
	void Start () {

        for(int y = 0; y < 5; y++)
        {
            for(int x = 0; x < 5; x++)
            {
                Instantiate(cube, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}


}
