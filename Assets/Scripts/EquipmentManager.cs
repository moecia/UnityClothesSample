using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    [SerializeField] private Transform hairSlot;
    [SerializeField] private Transform clothSlot;
    [SerializeField] private Transform pantSlot;
    [SerializeField] private Transform shoesSlot;
    [SerializeField] private SkinnedMeshRenderer avatarSkinnedMesh;

    public Transform HairSlot { get => hairSlot; }
    public Transform ClothSlot { get => clothSlot; }
    public Transform PantSlot { get => pantSlot; }
    public Transform ShoesSlot { get => shoesSlot; }

    public int HairId { get; set; }
    public int ClothId { get; set; }
    public int PantId { get; set; }
    public int ShoesId { get; set; }

    public void LoadEquipment()
    {
        ChangeOutfit(OutfitType.Hair, 1);
        ChangeOutfit(OutfitType.Cloth, 1);
        ChangeOutfit(OutfitType.Pant, 1);
        ChangeOutfit(OutfitType.Shoes, 1);
    }

    public void ChangeOutfit(OutfitType outfitType, int outfitId)
    {
        GameObject outfit = null;
        Transform target = null;
        switch (outfitType)
        {
            case OutfitType.Hair:
                outfit = Resources.Load<GameObject>($"Outfit/Hair/{outfitId}");
                target = hairSlot;
                if (hairSlot.childCount > 0)
                {
                    Destroy(hairSlot.GetChild(0).gameObject);
                }
                HairId = outfitId;
                break;
            case OutfitType.Cloth:
                outfit = Resources.Load<GameObject>($"Outfit/Clothes/{outfitId}");
                target = clothSlot;
                if (clothSlot.childCount > 0)
                {
                    Destroy(clothSlot.GetChild(0).gameObject);
                }
                ClothId = outfitId;
                break;
            case OutfitType.Pant:
                outfit = Resources.Load<GameObject>($"Outfit/Pants/{outfitId}");
                target = pantSlot;
                if (pantSlot.childCount > 0)
                {
                    Destroy(pantSlot.GetChild(0).gameObject);
                }
                PantId = outfitId;
                break;
            case OutfitType.Shoes:
                outfit = Resources.Load<GameObject>($"Outfit/Shoes/{outfitId}");
                target = shoesSlot;
                if (shoesSlot.childCount > 0)
                {
                    Destroy(shoesSlot.GetChild(0).gameObject);
                }
                ShoesId = outfitId;
                break;
        }
        var outfitObj = Instantiate(outfit, target);
        var smr = outfitObj.GetComponent<Outfit>().SkinnedMeshRenderer;
        var bones = SkinedMeshHelper.GetNewBones(avatarSkinnedMesh, smr);
        smr.bones = bones;
    }
}
