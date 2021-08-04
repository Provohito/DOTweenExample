using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

namespace MainFolder
{
    public class ChangeText : MonoBehaviour
    {
        [SerializeField] private Text _text1;
        [SerializeField] private Text _text2;
        [SerializeField] private Text _text3;

        private void Start()
        {
            _text1.DOText("Я заменил этот текст.", 3); // Замена текста
            _text2.DOText(" Дополнение к тексту!", 3).SetRelative(); // Дополняем текст к существующему
            _text3.DOText("Я взломал этот текст !", 3, true, ScrambleMode.Lowercase); // Анимация "Взлома" текста
            _text3.DOColor(Color.red, 3);
        }


    }
}
