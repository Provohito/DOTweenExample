using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace MainFolder
{
    public class ChangeColor : MonoBehaviour
    {
        private SpriteRenderer _spriteRenderer;
        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            
            _spriteRenderer.DOColor(Color.green, 2).SetLoops(-1, LoopType.Yoyo); // �-��� ����� ����� �� n-�� �����
            _spriteRenderer.DOFade(0, 0.5f).SetLoops(-1, LoopType.Yoyo); // �-��� ��������� �� n-�� �����
        }
    }
}
