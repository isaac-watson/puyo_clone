using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puyo {

    public enum PuyoColor { RED, BLUE, YELLOW, GREEN, PURPLE };
    private PuyoColor puyoColor;
    
    //Position with respect to board puyo array
    private int x, y;
    
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

	public Puyo(PuyoColor puyoColor)
    {
        x = 3;
        y = 0;
        this.puyoColor = puyoColor;
    }


    
}
