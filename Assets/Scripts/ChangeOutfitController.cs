using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeOutfitController : MonoBehaviour
{
    [SerializeField] private Button prevHair;
    [SerializeField] private Button nextHair;
    [SerializeField] private Button prevCloth;
    [SerializeField] private Button nextCloth;
    [SerializeField] private Button prevPant;
    [SerializeField] private Button nextPant;
    [SerializeField] private Button prevShoes;
    [SerializeField] private Button nextShoes;

    [SerializeField] private EquipmentManager equipmentMgr;

    private int currClothIndex = 1;
    private int currHairIndex = 1;
    private int currPantIndex = 1;
    private int currShoesIndex = 1;

    // Start is called before the first frame update
    void Start()
    {
        equipmentMgr.LoadEquipment();

        prevHair.onClick.AddListener(() => { ChangeOutfit(OutfitType.Hair, false); });
        nextHair.onClick.AddListener(() => { ChangeOutfit(OutfitType.Hair, true); });
        prevCloth.onClick.AddListener(() => { ChangeOutfit(OutfitType.Cloth, false); });
        nextCloth.onClick.AddListener(() => { ChangeOutfit(OutfitType.Cloth, true); });
        prevPant.onClick.AddListener(() => { ChangeOutfit(OutfitType.Pant, false); });
        nextPant.onClick.AddListener(() => { ChangeOutfit(OutfitType.Pant, true); });
        prevShoes.onClick.AddListener(() => { ChangeOutfit(OutfitType.Shoes, false); });
        nextShoes.onClick.AddListener(() => { ChangeOutfit(OutfitType.Shoes, true); });
    }

    private void ChangeOutfit(OutfitType outfitType, bool isNext)
    {
        switch (outfitType)
        {
            case OutfitType.Hair:
                if (isNext)
                {
                    currHairIndex = currHairIndex < 5 ? ++currHairIndex : 1;
                }
                else
                {
                    currHairIndex = currHairIndex > 1 ? --currHairIndex : 5;
                }
                equipmentMgr.ChangeOutfit(outfitType, currHairIndex);
                break;
            case OutfitType.Cloth:
                if (isNext)
                {
                    currClothIndex = currClothIndex < 5 ? ++currClothIndex : 1;
                }
                else
                {
                    currClothIndex = currClothIndex > 1 ? --currClothIndex : 5;
                }
                equipmentMgr.ChangeOutfit(outfitType, currClothIndex);
                break;
            case OutfitType.Pant:
                if (isNext)
                {
                    currPantIndex = currPantIndex < 5 ? ++currPantIndex : 1;
                }
                else
                {
                    currPantIndex = currPantIndex > 1 ? --currPantIndex : 5;
                }
                equipmentMgr.ChangeOutfit(outfitType, currPantIndex);
                break;
            case OutfitType.Shoes:
                if (isNext)
                {
                    currShoesIndex = currShoesIndex < 5 ? ++currShoesIndex : 1;
                }
                else
                {
                    currShoesIndex = currShoesIndex > 1 ? --currShoesIndex : 5;
                }
                equipmentMgr.ChangeOutfit(outfitType, currShoesIndex);
                break;
        }
    }
}
