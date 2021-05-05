using UnityEngine;

public class Outfit : MonoBehaviour
{
    [SerializeField] private OutfitType outfitType;
    private SkinnedMeshRenderer skinnedMeshRenderer;

    public OutfitType OutfitType { get => outfitType; set => outfitType = value; }
    public int Id { get => int.Parse(this.name); }
    public SkinnedMeshRenderer SkinnedMeshRenderer
    {
        get
        {
            if (skinnedMeshRenderer == null)
            {
                skinnedMeshRenderer = this.GetComponentInChildren<SkinnedMeshRenderer>();
            }
            return skinnedMeshRenderer;
        }
    }
}

public enum OutfitType
{
    Hair,
    Cloth,
    Pant,
    Shoes
}
