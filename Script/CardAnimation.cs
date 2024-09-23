using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CardAnimation : MonoBehaviour
{
    public GameObject[] Cards;
    public Vector3 defaultScale;
   
    void Start()
    {
        Debug.Log("CardAnimation");
        defaultScale = transform.localScale;
    }



    void OnMouseEnter()
    {
        transform.DOScale(defaultScale * 1.6f, 1.6f);
    }
    void OnMouseExit()
    {
        transform.DOScale(defaultScale, 1.6f);
    }
    void OnMouseDown()
    {
        transform.DORotate(new Vector3(0, 360, 0), 1f, RotateMode.LocalAxisAdd).SetEase(Ease.InOutSine);
        transform.DOShakePosition(6f, 7f, 20, 45);
    }
  
        }


   

