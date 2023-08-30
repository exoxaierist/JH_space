using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebriBillboard : MonoBehaviour
{
    private float random;
    private float offset;
    private DebriCenter center;
    private SpriteRenderer spr;

    private void Start()
    {
        offset = Random.Range(0, 360);
        random = Random.Range(-5, 5);

        center = transform.parent.GetComponent<DebriCenter>();
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = center.sprites[Random.Range(0, center.sprites.Count)];
    }

    private void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(0, 180, Time.time*random + offset);
    }
}
