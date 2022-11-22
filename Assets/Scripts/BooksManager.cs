using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BooksManager : MonoBehaviour
{
    public List<Sprite> bookPages;

    public RectTransform backgroundBox;

    private void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
    }

    private void OnMouseDown()
    {
        backgroundBox.LeanScale(Vector2.one, 0.5f);
        Book.instance.AssignHiddenObjects(bookPages);
    }


}
