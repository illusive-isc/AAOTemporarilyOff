using jp.illusive_isc.blocker;
using nadena.dev.ndmf;

[assembly: ExportsPlugin(typeof(IllAAOBlockerDifinition))]

namespace jp.illusive_isc.blocker
{
    public class IllAAOBlockerDifinition : Plugin<IllAAOBlockerDifinition>
    {
        public override string QualifiedName => "IllusoryOverride.IllAAOBlocker";
        public override string DisplayName => "IllAAOBlocker";

        protected override void Configure()
        {
            InPhase(BuildPhase.Resolving)
                .BeforePlugin("com.anatawa12.avatar-optimizer")
                .Run(IllAAOBlockerPass.Instance);
        }
    }
}
