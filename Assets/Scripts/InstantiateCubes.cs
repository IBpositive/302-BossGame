using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class InstantiateCubes : MonoBehaviour
{
    public GameObject cubePrefab;
    GameObject[] cube = new GameObject[20];
    public float maxScale;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject instanceCube = (GameObject)Instantiate(cubePrefab);
            instanceCube.transform.position = this.transform.position;
            instanceCube.transform.parent = this.transform;
            instanceCube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, 18f * i, 0);
            instanceCube.transform.position = Vector3.forward * 100;
            cube[i] = instanceCube;

        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 20; i++)
        {
            if(cube != null)
            {
                //https://youtu.be/Ri1uNPNlaVs?t=208
                cube[i].transform.localScale = new Vector3(10, AudioVis.samples[i] * maxScale +2, 10);
            }
        }
    }
}
