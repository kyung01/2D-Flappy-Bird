using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//게임을 새로 시작하는 걸 목적으로 하는 클라스
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
