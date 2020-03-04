using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomButtonColour : MonoBehaviour
{

    public Button button;

    public void TurnWhite()
    {
        ColorBlock colors = button.colors;
        colors.normalColor = Color.white;
        colors.highlightedColor = new Color32(225, 225, 225, 255);
        button.colors = colors;
    }


     private void OnMouseEnter()
    {
        TurnWhite();
    }
}
