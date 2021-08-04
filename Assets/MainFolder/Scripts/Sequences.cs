using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace MainFolder
{
    public class Sequences : MonoBehaviour
    {
        private void Start()
        {
            Sequence _sequence = DOTween.Sequence();

            _sequence.Append(transform.DOMoveY(3,4).SetRelative()); // ¬ставка первого элемента очереди, с перемещением по оси Y
            _sequence.Insert(0,transform.DORotate(new Vector3(90f, 40f, 0f), 2)); // вставка анимации кручени€ 

            _sequence.Append(transform.DOMoveX(4, 4).SetRelative());
            _sequence.Insert(4, transform.DORotate(new Vector3(0f, 180f, 50f), 2));
        }
    }
}
