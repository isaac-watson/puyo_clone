using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puyo : MonoBehaviour {

    public enum PuyoColor { RED, BLUE, YELLOW, GREEN, PURPLE };
    [SerializeField]
    protected PuyoColor puyoColor;
    
    //Position with respect to board puyo array
    private int x, y;

    void Start()
    {
        x = 3;
        y = 0;
        
    }
    void Update()
    {
        transform.position -= transform.up * Time.deltaTime * 5;
    }

    public int X
    {
        get { return x; }
        set { x = value; }

    }
    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public PuyoColor Color
    {
        get { return puyoColor; }
        set { puyoColor = value; }
    }
}
