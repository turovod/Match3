using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM_Play : MonoBehaviour
{
    public GameObject oFigure;
    public GameObject oTrigger;
    public Transform trPivot;
    public Sprite[] txFigure;
    public Figure[,] field=new Figure [7,7];
    public Figure emptyFigure;
    public static SM_Play singlton;

    private void Awake()
    {
        singlton = this;
    }
    void Start()
    {
        GameObject _g = Instantiate(oFigure);
        emptyFigure = _g.GetComponent<Figure>();
        _g.SetActive(false);
        emptyFigure.SetIndex(-1); // Зачем!
        InitField();
         Initialisation();

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void InitField()
    {
        for (int y = 0; y < 7; y++)
        {
            for (int x = 0; x < 7; x++)
            {
                field[x, y] = emptyFigure;
            }

        }

        for (int y = 0; y < 7; y++)
        {
            for (int x = 0; x < 7; x++)
            {
                GameObject _g = Instantiate(oFigure);
                _g.SetActive(false);
                int _index = GetIndex(x,y); //Зачем лишняя переменная
                Figure _figure = _g.GetComponent<Figure>(); //Зачем, есть emptyFigure
                _figure.Init(_index,x,y);
                field[x, y] = _figure;
              //  _g.GetComponent<SpriteRenderer>().sprite = txFigure[Random.Range(0, txFigure.Length)];
               // _g.transform.parent = trPivot;
              //  _g.transform.localPosition = new Vector3(index_, 0, 0);
              //  field[x, y] = emptyFigure;
            }

        }

    }

    int GetIndex(int x_,int y_) //Зачем сложно
    {
        int _index=Random.Range(0, txFigure.Length);
        if(y_==0)
        {
            if (x_ == 0)
            {
                while (_index == field[1, 0].index) _index = Random.Range(0, txFigure.Length);
            }
            else if (x_ == 6)
            {
                while (_index == field[5, 0].index) _index = Random.Range(0, txFigure.Length);
            }
            else
            {
                while (_index == field[x_-1, 0].index || _index == field[x_ + 1, 0].index) _index = Random.Range(0, txFigure.Length);
            }
        }

        else
        {
            if (x_ == 0)
            {
                while (_index == field[x_, y_-1].index || _index == field[1, y_].index ) _index = Random.Range(0, txFigure.Length);
            }
            else if (x_ == 6)
            {
                while (_index == field[x_, y_ - 1].index || _index == field[5, y_].index) _index = Random.Range(0, txFigure.Length);
            }
            else
            {
                while (_index == field[x_, y_ - 1].index || _index == field[x_ - 1, y_].index || _index == field[x_ + 1, y_].index) _index = Random.Range(0, txFigure.Length);
            }
        }
        return _index;
    }
    void Initialisation()
    {
        for(int x = 0; x < 7; x++)
        {
            GameObject _g = Instantiate(oTrigger); //as GameObject;
           // _g.GetComponent<SpriteRenderer>().sprite = txFigure[Random.Range(0, txFigure.Length)];
            _g.GetComponent<UpTrigger>().Init(x);
            _g.transform.parent = trPivot;
            _g.transform.localPosition = new Vector3(x, 0, 0);
        }
    }

    //public void CreateFigure(int index_)
    //{
    //       GameObject _g = Instantiate(oFigure);
    //        _g.GetComponent<SpriteRenderer>().sprite = txFigure[Random.Range(0, txFigure.Length)];
    //        _g.transform.parent = trPivot;
    //        _g.transform.localPosition = new Vector3(index_, 0, 0);
 
    //}

    public void LocateFigure(int index_,int y_)
    {
        //GameObject _g = Instantiate(oFigure);
        //_g.GetComponent<SpriteRenderer>().sprite = txFigure[Random.Range(0, txFigure.Length)];
        field[index_,y_].transform.parent = trPivot;
        field[index_, y_].transform.localPosition = new Vector3(index_, 0, 0);
        field[index_, y_].gameObject.SetActive(true);

    }

}
