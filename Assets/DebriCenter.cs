using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DebriCenter : MonoBehaviour
{
    public Vector3 radius = new(2,1,1);
    public MouseLookAt lookAt;
    public List<Sprite> sprites;

    private void Awake()
    {
        GetSprites();
    }

    private void Start()
    {
        Randomize();
    }

    private void Update()
    {
        transform.LookAt(lookAt.transform);
    }

    [ContextMenu("random")]
    private void Randomize()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            Vector3 random = Random.insideUnitSphere.normalized * Random.Range(0.7f,1.2f);
            random.Scale(radius);
            child.localPosition = random;
        }
    }

    private void GetSprites()
    {
        sprites = Resources.LoadAll<Sprite>("Debris").ToList();
    }
}
