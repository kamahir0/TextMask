using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    private int currentSelecting = 0;
    const float OFFSET = 55.5f;

    [SerializeField] RectTransform cursorRect;
    
    readonly Vector2 origin = new Vector2(0, 55.5f);

    // Update is called once per frame
    void Update()
    {
        // マウスホイールの回転量を取得
        float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
        // マウスホイールが上方向に回転した場合
        if (scrollWheel > 0f) currentSelecting--;
        // マウスホイールが下方向に回転した場合
        else if (scrollWheel < 0f) currentSelecting++;

        currentSelecting = (currentSelecting + 3) % 3;

        cursorRect.anchoredPosition = new Vector2(cursorRect.anchoredPosition.x, origin.y - currentSelecting * OFFSET);        
    }
}
