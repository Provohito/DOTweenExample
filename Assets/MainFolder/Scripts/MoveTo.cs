using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace MainFolder
{
    public class MoveTo : MonoBehaviour
    {
        public void Start()
        {
            //transform.DOMove(new Vector3(0,5,0), 3).SetLoops(4, LoopType.Restart);  // Анимация работает обрывками, к старту
            transform.DOMove(new Vector3(0, 5, 0), 3).SetLoops(4, LoopType.Yoyo); // Анимация работает циклом, "Туда - обратно", если поставить -1 , то анимация бесконечно производится
        }

    }
}
