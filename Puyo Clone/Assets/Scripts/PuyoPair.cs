using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuyoPair : MonoBehaviour {
    //
    private GameObject[] puyoPair;
    public GameObject puyo0;
    public GameObject puyo1;
    public GameObject puyo2;
    public GameObject puyo3;
    public GameObject puyo4;
    private bool isControlled;
    public enum PuyoDirection { NORTH, SOUTH, EAST, WEST };
    private PuyoDirection direction;

    void Start()
    {
        puyoPair = new GameObject[2];
        puyoPair[0] = RandomPuyo();
        puyoPair[1] = RandomPuyo();
        isControlled = false;
        direction = PuyoDirection.NORTH;
        TranslatePuyo();
    }
    void Update()
    {
        if (isControlled == true)
        {
            GetInput();
        }
    }

    public bool GetIsControlled()
    {
        return isControlled;
    }
    public void SetIsControlled(bool isControlled)
    {
        this.isControlled = isControlled;
    }
    public GameObject RandomPuyo()
    {
        GameObject puyo = null;
        int num = Random.Range(0, 5);
        switch (num)
        {
            case 0: //red
                puyo = GameObject.Instantiate(puyo0);
                break;
            case 1: //blue
                puyo = GameObject.Instantiate(puyo1);
                break;
            case 2: //yellow
                puyo = GameObject.Instantiate(puyo2);
                break;
            case 3: //green
                puyo = GameObject.Instantiate(puyo3);
                break;
            case 4: //purple
                puyo = GameObject.Instantiate(puyo4);
                break;
        }

        return puyo;
    }
    private void TranslatePuyo()
    {
        if (direction == PuyoDirection.NORTH)
        {
            puyoPair[0].transform.position = new Vector3(0, 1, 0);
        }

        
    }
    private void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2)) //Rotate counter-clockwise
        {
            if (direction == PuyoDirection.SOUTH)
            {
                direction = PuyoDirection.WEST;
                puyoPair[0].transform.position = new Vector3(-1, 0, 0);
                //puyoPair[1].transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 1, 0), Time.deltaTime*2);
            }
           else if (direction == PuyoDirection.WEST)
            {
                direction = PuyoDirection.NORTH;
                puyoPair[0].transform.position = new Vector3(0, 1, 0);
            }
           else if (direction == PuyoDirection.NORTH)
            {
                direction = PuyoDirection.EAST;
                puyoPair[0].transform.position = new Vector3(1, 0, 0);
            }
           else if (direction == PuyoDirection.EAST)
            {
                direction = PuyoDirection.SOUTH;
                puyoPair[0].transform.position = new Vector3(0, -1, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) //Rotate clockwise
        {
            if (direction == PuyoDirection.SOUTH)
            {
                direction = PuyoDirection.EAST;
                puyoPair[0].transform.position = new Vector3(1, 0, 0);
            }
            else if (direction == PuyoDirection.EAST)
            {
                direction = PuyoDirection.NORTH;
                puyoPair[0].transform.position = new Vector3(0, 1, 0);
            }
            else if (direction == PuyoDirection.NORTH)
            {
                direction = PuyoDirection.WEST;
                puyoPair[0].transform.position = new Vector3(-1, 0, 0);
            }
            else if (direction == PuyoDirection.WEST)
            {
                direction = PuyoDirection.SOUTH;
                puyoPair[0].transform.position = new Vector3(0, -1, 0);
            }
        }
    }
}
