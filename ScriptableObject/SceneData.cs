using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneData", menuName = "Persistence")]
public class SceneData : ScriptableObject 
{
    public bool isNextScene = true;
    public int health = 5;
    public int distance = 20;
}
