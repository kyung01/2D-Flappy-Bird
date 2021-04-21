using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ ���� �����ϴ� �� �������� �ϴ� Ŭ��
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] PipeManager pipeManager;
    [SerializeField] GroundManager groundManager;
    [SerializeField] Bird bird;



    private void Awake()
    {
        Instance = this;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    public void Restart()
    {
        pipeManager.Reset();
        groundManager.Reset();
        bird.Reset();

    }
}
