using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace MainFolder
{
    public class Path : MonoBehaviour
    {
        [SerializeField] private Vector3[] _wayPoints;
        
        private void Start()
        {
            Tween tween = transform.DOPath(_wayPoints, 5, PathType.CatmullRom).SetOptions(true).SetLookAt(0.1f); 
            // Путь(точки,время, тип анимации).Замкнуть путь.Поворачиваться в сторону следующей точки
            tween.SetEase(Ease.Linear).SetLoops(-1); // анимация.Установка типа анимации(Линейная).Зациклить
        }
    }
}
