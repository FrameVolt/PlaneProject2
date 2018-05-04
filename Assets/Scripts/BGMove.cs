using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class BGMove : MonoBehaviour {
    [SerializeField]
    private float speed = 0.3f;
    private SpriteRenderer spriteRenderer;

    private Material m_material;
   

    void Awake () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //m_material = spriteRenderer.material;

        m_material = spriteRenderer.sharedMaterial;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //m_material.SetTextureOffset("_MainTex", Vector2.up * Time.time);
        m_material.mainTextureOffset = Vector2.up * Time.time * speed;
        
    }
}
