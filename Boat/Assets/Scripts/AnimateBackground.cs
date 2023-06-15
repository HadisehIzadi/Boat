using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBackground : MonoBehaviour
{
	public Sprite[] sprites;
	private int spriteIndex;
	private SpriteRenderer spriteRenderer;
	
	private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length) {
            spriteIndex = 0;
        }

        if (spriteIndex < sprites.Length && spriteIndex >= 0) {
            spriteRenderer.sprite = sprites[spriteIndex];
        }
    }
}
