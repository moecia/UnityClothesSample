using System.Collections.Generic;
using UnityEngine;

public static class SkinedMeshHelper
{
    public static Transform[] GetNewBones(SkinnedMeshRenderer root, SkinnedMeshRenderer source)
    {
        List<Transform> bones = new List<Transform>();
        for (int i = 0; i < source.bones.Length; i++)
        {
            for (int j = 0; j < root.bones.Length; ++j)
            {
                if (source.bones[i].name.Equals(root.bones[j].name))
                {
                    bones.Add(root.bones[j]);
                    break;
                }
            }
        }
        return bones.ToArray();
    }
}
