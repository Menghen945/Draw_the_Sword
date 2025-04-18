using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttackShape
{
    Circle,
    Rectangle
}

[CreateAssetMenu(fileName = "AttackConfig", menuName = "Combat/Attack Config")]
public class PlayerAttackConfig : ScriptableObject
{
    [Header("Move")] 
    public Vector2 movement;
    public float movementTime;

    [Header("Offset")] 
    public float offsetX;
    public float offsetY;
    
    [Header("Knockback")] 
    public Vector2 knockbackPower;
    
    [Header("Shape and range")]
    public AttackShape shape;
    public float range;
    
    [Header("Rectangle")] public Vector2 size;
    
    public void DrawGizmos(Vector2 origin)
    {
        switch(shape)
        {
            case AttackShape.Circle:
                Gizmos.DrawWireSphere(origin, range);
                break;
            case AttackShape.Rectangle:
                Gizmos.DrawWireCube(origin, size);
                break;
        }
    }
}
