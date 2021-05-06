using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class SkinnedMeshHelper
{
    public static Transform[] GetNewBones(SkinnedMeshRenderer root, SkinnedMeshRenderer source)
    {
        return root.bones
            .Where(x => source.bones.Select(s => s.name).Contains(x.name)).ToArray();
    }
}
