using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField] GameObject PREFAB_PIPE;

    List<GameObject> pipes = new List<GameObject>();

    float maxHeight = 2.7f;
    float minHeight = -0.44f;
    float horizontalSpacing = 8;
    float lastPipeXPosition = 0;

    private void Awake()
    {
        int numPipe = 3;

        for (int i = 0; i < numPipe; i++)
        {
            pipes.Add(Instantiate(PREFAB_PIPE));
        }

        Reset();
    }
    public void Reset()
    {
        for (int i = 0; i < pipes.Count; i++)
        {
            lastPipeXPosition = 5 + horizontalSpacing * i;
            pipes[i].transform.position = new Vector3(lastPipeXPosition, Random.Range(minHeight, maxHeight), 0);


        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i< pipes.Count; i++)
        {
            if( Camera.main.transform.position.x -pipes[i].transform.position.x > 10)
            {
                lastPipeXPosition += horizontalSpacing;
                pipes[i].transform.position = new Vector3(lastPipeXPosition, Random.Range(minHeight, maxHeight), 0);

            }
        }
        
    }
}
