using BepInEx;
using HarmonyLib;

namespace ReverbRemoval
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        
        private void Awake()
        {
            Logger.LogInfo("Loading a mod by swAAn\n\n" +
                "                                    _\n" +
                "                                ,-\"\" \"\".\n" +
                "                              ,'  ____  `.\n" +
                "                            ,'  ,'    `.  `._\n" +
                "   (`.         _..--.._   ,'  ,'        \\    \\\n" +
                "  (`-.\\    .-\"\"        \"\"'   /          (  d _b\n" +
                " (`._  `-\"\" ,._             (            `-(   \\\n" +
                " <_  `     (  <`<            \\              `-._\\\n" +
                "  <`-       (__< <           :\n" +
                "   (__        (_<_<          ;\n" +
                "    `~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"
                );

            var harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            harmony.PatchAll();

            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}