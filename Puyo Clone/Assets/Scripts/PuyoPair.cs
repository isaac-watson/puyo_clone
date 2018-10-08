using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuyoPair : MonoBehaviour {
    //
    private GameObject[] puyoPair;
    public GameObject[] puyoList;
    private bool isControlled;
    public enum PuyoDirection { NORTH, SOUTH, EAST, WEST };
    private PuyoDirection direction;

    void Start()
    {
        
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
    public GameObject RandomPuyo(Vector3 Position)
    {
        GameObject puyo = null;
        int num = Random.Range(0, 5);
        switch (num)
        {
            case 0: //red
                puyo = Instantiate(puyoList[0], Position, Quaternion.identity) as GameObject;
                break;
            case 1: //blue
                puyo = Instantiate(puyoList[1], Position, Quaternion.identity) as GameObject;
                break;
            case 2: //yellow
                puyo = Instantiate(puyoList[2], Position, Quaternion.identity) as GameObject;
                break;
            case 3: //green
                puyo = Instantiate(puyoList[3], Position, Quaternion.identity) as GameObject;
                break;
            case 4: //purple
                puyo = Instantiate(puyoList[4], Position, Quaternion.identity) as GameObject;
                break;
        }
        
        return puyo;
    }
    public void InstantiatePair()
    {
        puyoPair = new GameObject[2];
        direction = PuyoDirection.NORTH;
        if (isControlled == true)
        {
            puyoPair[0] = RandomPuyo(new Vector3(-9.5f, 6.5f, 0));
            puyoPair[0].GetComponent<Puyo>().State = Puyo.PuyoState.IN_PLAY;
            puyoPair[1] = RandomPuyo(new Vector3(-9.5f, 5.5f, 0));
            puyoPair[1].GetComponent<Puyo>().State = Puyo.PuyoState.IN_PLAY;
        }
        if (isControlled == false)
        {
            puyoPair[0] = RandomPuyo(new Vector2(-4.5f, 6.5f));
            
            puyoPair[1] = RandomPuyo(new Vector3(-4.5f, 5.5f, 0));
        
        }
        
    }
    private void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2)) //Rotate counter-clockwise
        {
            if (direction == PuyoDirection.SOUTH)
            {
                direction = PuyoDirection.EAST;
                
               
            }
           else if (direction == PuyoDirection.WEST)
            {
                direction = PuyoDirection.NORTH;
                
            }
           else if (direction == PuyoDirection.NORTH)
            {
                direction = PuyoDirection.WEST;
                
            }
           else if (direction == PuyoDirection.EAST)
            {
                direction = PuyoDirection.NORTH;
                
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) //Rotate clockwise
        {
            if (direction == PuyoDirection.SOUTH)
            {
                direction = PuyoDirection.WEST;
               
            }
            else if (direction == PuyoDirection.EAST)
            {
                direction = PuyoDirection.SOUTH;
               
            }
            else if (direction == PuyoDirection.NORTH)
            {
                direction = PuyoDirection.EAST;
                
            }
            else if (direction == PuyoDirection.WEST)
            {
                direction = PuyoDirection.NORTH;
               
            }
        }
    }
}
