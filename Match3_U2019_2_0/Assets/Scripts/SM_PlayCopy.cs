using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM_PlayCopy : MonoBehaviour
{
    [SerializeField] private GameObject _chip;
    [SerializeField] private GameObject _trigger;
    [SerializeField] private Sprite[] _chipsTexture;
    [SerializeField] private  Transform _dotPivot;
    public static SM_PlayCopy singlton;

    private void Awake()
    {
        singlton = this;
    }

    void Start()
    {
        InitTrigger();
    }

    void Update()
    {
        
    }

    public void InitTrigger()
    {
        for (int x = 0; x < 7; x++)
        {
            GameObject trigger = Instantiate(_trigger);
            trigger.GetComponent<UpTrigger>().Init(x);
            trigger.transform.parent = _dotPivot;
            trigger.transform.localPosition = new Vector3(x, 0, 0);
        }
        
    }

    public void InitChips(int x)
    {
        GameObject chip = Instantiate(_chip);
        chip.GetComponent<SpriteRenderer>().sprite = _chipsTexture[Random.Range(0, _chipsTexture.Length)];
        chip.transform.parent = _dotPivot;
        chip.transform.localPosition = new Vector3(x, 0, 0);
    }
}
