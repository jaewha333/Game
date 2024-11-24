using System.Collections;
using System.Collections.Generic;
using Cinemachine.Utility;
using UnityEngine;

public class Follow : MonoBehaviour
{
    RectTransform rect;

    void Awake()
    {
        rect =GetComponent<RectTransform>();
    }
    void FixedUpdate()
    {
        rect.position = GameManager.instance.player.transform.position;
    }
}
