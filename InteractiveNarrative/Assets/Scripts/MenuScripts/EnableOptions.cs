using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOptions : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject HighlightImage;
    public SpriteRenderer HighlightSprite;
    Animator anim;
   

    private void OnMouseEnter()
    {
        HighlightSprite.enabled = true;
        anim.Play("Cog");
    }


    private void OnMouseExit()
    {
        HighlightSprite.enabled = false;
    }

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
