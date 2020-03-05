using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOptions : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject HighlightImage;
    public SpriteRenderer HighlightSprite;
   

    private void OnMouseEnter()
    {
        HighlightSprite.enabled = true;
    }


    private void OnMouseExit()
    {
        HighlightSprite.enabled = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
