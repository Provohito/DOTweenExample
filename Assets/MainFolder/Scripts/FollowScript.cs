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
            _tween = transform.DOMove(_target.position, 2).SetAutoKill(false); // ������ ������ �������� �����������, 
                                                                               //��� �� ��������� �� �������������
            _targetLastPosition = _target.position; // ����������� ��������� ����, ��������� ��������
        }

        private void Update()
        {
            if (_targetLastPosition != _target.position)
            {
                _tween.ChangeEndValue(_target.position, true).Restart(); // �������� �������� � ������ ��������, 
                                                                         //��� ���������� �������������
                _targetLastPosition = _target.position;
            }
        }
    }
}
