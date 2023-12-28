using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterScreenFollow : MonoBehaviour
{
    [SerializeField] Transform follow;
    [SerializeField] Camera camera;
    [SerializeField] RectTransform uiObject;

    private void Update()
    {
        uiObject.position = camera.WorldToScreenPoint(follow.position);
    }
}
