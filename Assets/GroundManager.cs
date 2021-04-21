using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField] List<GameObject> groundPieces;

    List<Vector3> groundPositions = new List<Vector3>();

    float groundYOffset = -5.8f; //자기 마음대로 
    float lastGroundPosition = 0;
    float horizontalSpacing = 14.78f; //자기 마음대로 

    private void Awake()
    {
        for (int i = 0; i < groundPieces.Count; i++)
        {
            groundPositions.Add(groundPieces[i].transform.position);
            if (groundPieces[i].transform.position.x > lastGroundPosition)
            {
                lastGroundPosition = groundPieces[i].transform.position.x;
            }

        }
    }

    public void Reset()
    {
        for (int i = 0; i < groundPieces.Count; i++)
        {
            groundPieces[i].transform.position = groundPositions[i];

        }
        lastGroundPosition = 0;
        for (int i = 0; i < groundPieces.Count; i++)
        {
            if (groundPieces[i].transform.position.x > lastGroundPosition)
            {
                lastGroundPosition = groundPieces[i].transform.position.x;
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        for (int i = 0; i < groundPieces.Count; i++)
        {
            if (Camera.main.transform.position.x - groundPieces[i].transform.position.x > 17)
            {
                lastGroundPosition += horizontalSpacing;
                groundPieces[i].transform.position = new Vector3(lastGroundPosition, groundYOffset, 0);

            }
        }

    }
}
