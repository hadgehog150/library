using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavelManager : MonoBehaviour
{
    public RectTransform backgroundBox;

    public void Close()
    {
        backgroundBox.LeanScale(Vector2.zero, 0.5f);
    }
}

