using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(menuName = "Fruit Settings", fileName = "FruitSettings", order = 0)]
public class FruitObjectSetting : ScriptableObject
{

    [SerializeField] private FruitObject prefab;
    [SerializeField] private List<Sprite> sprites;
    [SerializeField] private List<float> scales;

    public FruitObject SpawnObject => prefab;

    public Sprite GetSprite(int index)
    {
        if (index < 0 || index >= sprites.Count)
        {
            Debug.LogError(message: "Out Of Range Hocam");
        }

        return sprites[index];
    }

    public float GetScale(int index)
    {
        if (index < 0 || index >= scales.Count)
        {
            Debug.LogError(message: "Out Of Range Hocam");
        }
        return scales[index];
    }

    [ContextMenu(nameof(SetScale))]
    public void SetScale()
    {
        scales.Clear();
        for (int i = 0; i < sprites.Count; i++)
        {
            scales.Add((i + 1) * .25f);
        }
    }
}
