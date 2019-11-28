using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTrigger : MonoBehaviour
{
    public int indexTrigger;
    public int y;

    void Start()
    {
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
		y++;
		if (y<7) SM_Play.singlton.LocateFigure(indexTrigger,y);
    }
    public void Init(int index_)
    {
        indexTrigger = index_;
		SM_Play.singlton.LocateFigure(indexTrigger, y);
    }
}
