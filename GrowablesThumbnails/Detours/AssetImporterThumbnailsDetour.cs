using GrowablesThumbnails.Redirection;

namespace GrowablesThumbnails.Detours
{
    [TargetType(typeof(AssetImporterThumbnails))]
    public class AssetImporterThumbnailsDetour
    {
        [RedirectMethod]
        public static bool NeedThumbnails(PrefabInfo info)
        {
            VehicleInfo vehicleInfo = info as VehicleInfo;
            if ((UnityEngine.Object)vehicleInfo != (UnityEngine.Object)null)
                return false;
            return true;
        }
    }
}