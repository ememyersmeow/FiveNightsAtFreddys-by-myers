using UnityEngine;

public class NextPoints : MonoBehaviour
{
    public Transform[] NextChackPoints;
    public int id;
    public EnemyController controller;
    int Chance;

    private void Awake()
    {
        StartChance();
    }

    void StartChance()
    {
        controller.toPlayerChance = 100;
        Chance = controller.toPlayerChance;
    }

    void SetChance()
    {
        if(id == 1)
        {
            controller.toPlayerChance = 50;
        }
        else if(id == 11 | id == 10)
        {
            controller.toPlayerChance = 100;
        }
    }

    public Transform getNext()
    {
        SetChance();
        Chance = controller.toPlayerChance;
        int rand = Random.Range(1, 100);
        if (rand <= Chance)
        {
            if(NextChackPoints.Length > 1)
            {
                return NextChackPoints[Random.Range(1, NextChackPoints.Length)];
            }
            else
            {
                return NextChackPoints[0];
            }
        }
        else
        {
            return NextChackPoints[0];
        }
    }
}
