using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CollectableType
{
    SmallPoints, BigPoints, BiggerPoints
}

public class Collectable : MonoBehaviour
{
    [SerializeField]
    private CollectableType type = CollectableType.SmallPoints;

    private void Start()
    {
        GetComponentInChildren<Light>().color = GetColor();
    }

    public int NumberOfPoints()
    {
        switch (type)
        {
            case CollectableType.SmallPoints:
                return 10;
            case CollectableType.BigPoints:
                return 20;
            case CollectableType.BiggerPoints:
                return 30;
        }
        return 0;
    }

    public Color GetColor()
    {
        switch (type)
        {
            case CollectableType.SmallPoints:
                return Color.red;
            case CollectableType.BigPoints:
                return Color.green;
            case CollectableType.BiggerPoints:
                return new Color(0.59f, 0.11f, 0.59f);
        }
        return Color.grey;
    }
}
