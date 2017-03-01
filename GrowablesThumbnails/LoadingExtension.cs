using GrowablesThumbnails.Detours;
using GrowablesThumbnails.Redirection;
using ICities;

namespace GrowablesThumbnails
{
    public class LoadingExtension : LoadingExtensionBase
    {
        public override void OnCreated(ILoading loading)
        {
            base.OnCreated(loading);
            Redirector<AssetImporterThumbnailsDetour>.Deploy();
        }

        public override void OnReleased()
        {
            base.OnReleased();
            Redirector<AssetImporterThumbnailsDetour>.Revert();
        }
    }
}