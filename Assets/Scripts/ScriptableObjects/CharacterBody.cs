using UnityEngine;

[CreateAssetMenu(fileName = "New Char Body", menuName = "Char Body")]
public class CharacterBody : ScriptableObject
{
    public BodyPartData[] bodyParts;
}

[System.Serializable]
public class BodyPartData
{
    public string bodyPartName;
    public BodyPart bodyPart;
}
