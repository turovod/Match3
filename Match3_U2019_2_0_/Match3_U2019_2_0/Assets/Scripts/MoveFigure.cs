using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFigure : MonoBehaviour
{
    public Figure figureDown;
    public Figure figureUp;
    public int state;
    public static MoveFigure singleton;

    private void Awake()
    {
        singleton = this; // Почему так а не через GetComponent
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickEnter(Figure figure_)
    {
        state = 1;
        figureUp = figure_;
    }
    public void ClickUp(Figure figure_)
    {

        figureDown = figure_;
        Debug.Log("m1 " + figureDown.x + " " + figureDown.y + "   " + figureUp.x + " " + figureUp.y);
        if (figureDown.x == figureUp.x)
        {
            Debug.Log("m2");

            int _dy = figureDown.y - figureUp.y;
            if (_dy == 1 || _dy == -1)
            {
                Debug.Log("m3");
                Move();
            }
        }
        if (figureDown.y == figureUp.y)
        {
            int _dx = figureDown.x - figureUp.x;
            if (_dx == 1 || _dx == -1)
            {
                Move();
            }
        }
    }

    public void Move()
    {
        Debug.Log("move");
        int _index = figureDown.index;
        figureDown.SetIndex(figureUp.index);
        figureUp.SetIndex(_index);

    }
}
