using Anatawa12.AvatarOptimizer;
using jp.illusive_isc.temporarilyOff;
using nadena.dev.ndmf;
using UnityEngine;

namespace jp.illusive_isc.blocker
{
    public class AAOTemporarilyOffPass : Pass<AAOTemporarilyOffPass>
    {
        protected override void Execute(BuildContext context)
        {
            foreach (var Blocker in Object.FindObjectsOfType<AAOTemporarilyOff>())
            {
                if (Blocker.gameObject.activeInHierarchy)
                {
                    foreach (var TAO in Object.FindObjectsOfType<TraceAndOptimize>())
                    {
                        Object.DestroyImmediate(TAO);
                    }
                    foreach (var ATC in Object.FindObjectsOfType<AvatarTagComponent>())
                    {
                        Object.DestroyImmediate(ATC);
                    }
                }
                Object.DestroyImmediate(Blocker);
            }
        }
    }
}
