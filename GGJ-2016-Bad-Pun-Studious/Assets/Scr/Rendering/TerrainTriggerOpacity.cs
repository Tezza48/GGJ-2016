using UnityEngine;
using System.Collections;

public class TerrainTriggerOpacity : MonoBehaviour {

    private float minimumAlpha = 0.2f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Terrain"))
        {
            SpriteRenderer sprite = other.GetComponent<SpriteRenderer>();
            Color spriteColor = sprite.color;
            spriteColor.a = minimumAlpha;
            sprite.color = spriteColor;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Terrain"))
        {
            SpriteRenderer sprite = other.GetComponent<SpriteRenderer>();
            Color spriteColor = sprite.color;
            spriteColor.a = 1;
            sprite.color = spriteColor;
        }
    }
}
