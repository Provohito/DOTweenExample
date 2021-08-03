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

            _spriteRenderer.DOColor(Color.red, 2).SetLoops(-1, LoopType.Yoyo); // Ф-ция смены цвета за n-e количество времени
            _spriteRenderer.DOFade(0, 0.5f).SetLoops(-1, LoopType.Yoyo); // Ф-ция затухания за n-e количество времени
        }
    }
}

