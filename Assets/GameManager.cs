using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ ���� �����ϴ� �� �������� �ϴ� Ŭ��
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] GameObject UI_gameRestart;

    [SerializeField] PipeManager pipeManager;
    [SerializeField] GroundManager groundManager;
    [SerializeField] Bird bird;


    [SerializeField] TMPro.TMP_Text scoreText;


    int score = 0;
    public void AddScore(int n)
    {
        score += n;
        scoreText.text = "" + score;
    }



    private void Awake()
    {
        Instance = this;
        bird.hdrBirdDead = this.handlerBirdDead;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    void handlerBirdDead(Bird bird)
    {
        //���� ����� �Ŵ��� �����Ҳ�����
        UI_gameRestart.SetActive(true);
    }

    public void handlerGameRestartedBttnClicked()
    {
        Restart();
        UI_gameRestart.SetActive(false);
    }




    public void Restart()
    {

        score = 0;
        scoreText.text = "" + score;

        pipeManager.Reset();
        groundManager.Reset();
        bird.Reset();

    }
}
