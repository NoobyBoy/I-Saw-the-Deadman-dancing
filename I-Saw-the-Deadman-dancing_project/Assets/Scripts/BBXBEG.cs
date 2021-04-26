using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BBXBEG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        RectTransform rt = GetComponent<RectTransform>();
        rt.DOMoveX(-1700, 4.5f).SetEase(Ease.Linear).OnComplete(() => { Destroy(this.gameObject); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
