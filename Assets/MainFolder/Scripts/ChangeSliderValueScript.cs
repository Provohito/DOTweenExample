using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

namespace MainFolder
{
    public class ChangeSliderValueScript : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        private void Start()
        {
            _slider.DOValue(1,2).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        }
    }
}
