using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private InGameRanking ig;
   

    private GameObject[] runners;
    List<RankingSystem> sortArray = new List<RankingSystem>();

    public bool isGameOver = false;

	private void Awake()
	{
        instance = this;
        runners = GameObject.FindGameObjectsWithTag("Runner");
        ig = FindObjectOfType<InGameRanking>();
	}

	// Start is called before the first frame update
	void Start()
    {
		for (int i = 0; i < runners.Length; i++)
		{
            sortArray.Add(runners[i].GetComponent<RankingSystem>());
		}
    }

    void CalculateRank()
	{
        sortArray = sortArray.OrderBy(x => x.distance).ToList();
        sortArray[0].rank = 1;
        sortArray[1].rank = 2;
        sortArray[2].rank = 3;
        sortArray[3].rank = 4;
        sortArray[4].rank = 5;
        sortArray[5].rank = 6;
        sortArray[6].rank = 7;
        sortArray[7].rank = 8;
        sortArray[8].rank = 9;
        sortArray[9].rank = 10;
        sortArray[10].rank = 11;

        ig.a = sortArray[10].name;
        ig.b = sortArray[9].name;
        ig.c = sortArray[8].name;
        ig.d = sortArray[7].name;
        ig.e = sortArray[6].name;
        ig.f = sortArray[5].name;
        ig.g = sortArray[4].name;
        ig.h = sortArray[3].name;
        ig.j = sortArray[2].name;
        ig.k = sortArray[1].name;
        ig.l = sortArray[0].name;

    }

    // Update is called once per frame
    void Update()
    {
        CalculateRank();
    }
}
