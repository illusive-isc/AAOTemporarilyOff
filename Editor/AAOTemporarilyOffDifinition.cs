using jp.illusive_isc.blocker;
using nadena.dev.ndmf;

[assembly: ExportsPlugin(typeof(AAOTemporarilyOffDifinition))]

namespace jp.illusive_isc.blocker
{
    public class AAOTemporarilyOffDifinition : Plugin<AAOTemporarilyOffDifinition>
    {
        public override string QualifiedName => "IllusoryOverride.AAOTemporarilyOff";
        public override string DisplayName => "AAOTemporarilyOff";

        protected override void Configure()
        {
            InPhase(BuildPhase.Resolving)
                .BeforePlugin("com.anatawa12.avatar-optimizer")
                .Run(AAOTemporarilyOffPass.Instance);
        }
    }
}
