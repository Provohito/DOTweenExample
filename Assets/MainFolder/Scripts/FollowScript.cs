using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace MainFolder
{
    public class FollowScript : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        private Vector3 _targetLastPosition;
        private Tweener _tween;

        private void Start()
        {
            _tween = transform.DOMove(_target.position, 2).SetAutoKill(false); // Делаем синмок анимации перемещения, 
                                                                               //так же запрещаем ей самоудаляться
            _targetLastPosition = _target.position; // Присваиваем положение цели, положению охотника
        }

        private void Update()
        {
            if (_targetLastPosition != _target.position)
            {
                _tween.ChangeEndValue(_target.position, true).Restart(); // Изменяем значение в снимке анимации, 
                                                                         //для реализации преследования
                _targetLastPosition = _target.position;
            }
        }
    }
}
