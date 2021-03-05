using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Piece : MonoBehaviour
{
    public bool deleteFlag;

    // private.
    private Image thisImage;
    private RectTransform thisRectTransform;
    private PieceKind kind;

    //-------------------------------------------------------
    // MonoBehaviour Function
    //-------------------------------------------------------
    // 初期化処理
    private void Awake()
    {
        // アタッチされている各コンポーネントを取得
        thisImage = GetComponent<Image>();
        thisRectTransform = GetComponent<RectTransform>();

        // フラグを初期化
        deleteFlag = false;
    }

    //-------------------------------------------------------
    // Public Function
    //-------------------------------------------------------
    // ピースの種類とそれに応じた色をセットする
    public void SetKind(PieceKind pieceKind)
    {
        kind = pieceKind;
        SetColor();
    }

    // ピースの種類を返す
    public PieceKind GetKind()
    {
        return kind;
    }

    // ピースのサイズをセットする
    public void SetSize(int size)
    {
        this.thisRectTransform.sizeDelta = Vector2.one * size;
    }

    //-------------------------------------------------------
    // Private Function
    //-------------------------------------------------------
    // ピースの色を自身の種類の物に変える
    private void SetColor()
    {
        switch (kind)
        {
            case PieceKind.FireBall:
                thisImage.color = Color.red;
                break;
            case PieceKind.WaterBall:
                thisImage.color = Color.blue;
                break;
            case PieceKind.WindBall:
                thisImage.color = Color.green;
                break;
            case PieceKind.LightBall:
                thisImage.color = Color.yellow;
                break;
            case PieceKind.DarkBall:
                thisImage.color = Color.black;
                break;
            case PieceKind.PinkBall:
                thisImage.color = Color.magenta;
                break;
            default:
                break;
        }
    }
}