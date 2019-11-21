using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTrigger : MonoBehaviour
{
    public int indexTrigger;
    public int y;

    void Start()
    {
        //SM_Play.singlton.CreateFigure(indexTrigger);
        //SM_PlayCopy.singlton.InitChips(indexTrigger);
        SM_Play.singlton.LocateFigure(indexTrigger, y);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        y++;
        if(y<7) SM_Play.singlton.LocateFigure(indexTrigger, y);
        //SM_Play.singlton.CreateFigure(indexTrigger);
        //SM_PlayCopy.singlton.InitChips(indexTrigger);
    }

 
    void Update()
    {
        
    }

    public void Init(int index_)
    {
        indexTrigger = index_;
    }
}
