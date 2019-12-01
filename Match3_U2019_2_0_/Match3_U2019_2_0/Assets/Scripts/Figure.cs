using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    public int index;
    public int x;
    public int y;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Init(int index_, int x_, int y_)
    {
        index = index_;
        x = x_;
        y = y_;
        GetComponent<SpriteRenderer>().sprite = SM_Play.singlton.txFigure[index];
    }
    public void SetIndex(int index_)
    {
        index = index_;
        if (index >= 0) GetComponent<SpriteRenderer>().sprite = SM_Play.singlton.txFigure[index];
    }

    //public void OnMouseDown()
    //{
    //    MoveFigure.singleton.ClickDown(this);
    //    Debug.Log("down");
    //}

    private void OnMouseUp()
    {
        MoveFigure.singleton.ClickUp(this);
    }
    private void OnMouseEnter()
    {
        MoveFigure.singleton.ClickEnter(this);
    }

    public void SetCoord(int x_, int y_)
    {
        x = x_;
        y = y_;
    }


}
