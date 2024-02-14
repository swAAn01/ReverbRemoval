using HarmonyLib;
using UnityEngine;

namespace ReverbRemoval
{
    [HarmonyPatch(typeof(OccludeAudio))]
    class OccludeAudioPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("Update")]
        static void UpdatePrefix(ref OccludeAudio __instance)
        {
            __instance.useReverb = false;
            if (__instance.gameObject.GetComponent<AudioReverbFilter>())
                __instance.gameObject.GetComponent<AudioReverbFilter>().enabled = false;
        }
    }
}
