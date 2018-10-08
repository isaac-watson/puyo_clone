using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {
    //Need to move the iscontrolled factor from puyopair to here
    private GameObject[,] puyoBoard;
    public GameObject puyoPair;
    private GameObject[] pairSet;
    private float xOffset = -12;
    private float yOffset = 6;

	// Use this for initialization
	void Awake () {
        puyoBoard = new GameObject[7,12];
        pairSet = new GameObject[2];
        GenerateNextPair();
        SetControlledPair();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void SetControlledPair()
    {
        pairSet[0] = pairSet[1];
        pairSet[0].GetComponent<PuyoPair>().SetIsControlled(true);
        pairSet[0].GetComponent<PuyoPair>().InstantiatePair();
        
    }
    //The pair to replace in board's puyoPairs
    private void GenerateNextPair()
    {
        pairSet[1] = GameObject.Instantiate(puyoPair);
        pairSet[1].GetComponent<PuyoPair>().SetIsControlled(false);
        pairSet[1].GetComponent<PuyoPair>().InstantiatePair();
    }
}
