using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    public int index;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(int index_)
    {
        index = index_;
        GetComponent<SpriteRenderer>().sprite = SM_Play.singlton.txFigure[index];
    }
    public void SetIndex(int index_)
    {
        index = index_;
        //GetComponent<SpriteRenderer>().sprite = SM_Play.singlton.txFigure[index];
    }
}
