using NuggetMod.Enum.Metamod;
using NuggetMod.Interface;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NuggetMod.Template;

public class NativeEntry : PluginEntry
{
    static NativeEntry()
    {
        Interface = new Plugin();
    }

    /// <summary>
    /// Unmanaged GiveFnptrsToDll
    /// </summary>
    /// <param name="pengfuncsFromEngine"></param>
    /// <param name="pGlobals"></param>
    [UnmanagedCallersOnly(EntryPoint = "GiveFnptrsToDll")]
    public static void UnmanagedGiveFnptrsToDll(nint pengfuncsFromEngine, nint pGlobals)
    {
        Native_GiveFnptrsToDll(pengfuncsFromEngine, pGlobals);
    }

    /// <summary> 
    /// Unmanaged Meta_Init(Optional)
    /// </summary>
    //[UnmanagedCallersOnly(EntryPoint = "Meta_Init", CallConvs = [typeof(CallConvCdecl)])]
    public static void UnmanagedMeta_Init()
    {
        Native_Meta_Init();
    }

    /// <summary>
    /// Unmanaged Meta_Query
    /// </summary>
    /// <param name="interfaceVersion">char *interfaceVersion</param>
    /// <param name="plinfo">plugin_info_t **pinfo</param>
    /// <param name="pMetaUtilFuncs">mutil_funcs_t *pMetaUtilFuncs</param>
    /// <returns>query ok or not</returns>
    [UnmanagedCallersOnly(EntryPoint = "Meta_Query", CallConvs = [typeof(CallConvCdecl)])]
    public static int UnmanagedMeta_Query(nint interfaceVersion, nint plinfo, nint pMetaUtilFuncs)
    {
        return Native_Meta_Query(interfaceVersion, plinfo, pMetaUtilFuncs);
    }

    /// <summary>
    /// Unmanaged Meta_Attach
    /// </summary>
    /// <param name="now">PLUG_LOADTIME now</param>
    /// <param name="pFunctionTable">META_FUNCTIONS *pFunctionTable</param>
    /// <param name="pMGlobals">meta_globals_t *pMGlobals</param>
    /// <param name="pGamedllFuncs">gamedll_funcs_t *pGamedllFuncs</param>
    /// <returns>attch ok or not</returns>
    [UnmanagedCallersOnly(EntryPoint = "Meta_Attach", CallConvs = [typeof(CallConvCdecl)])]
    public static int UnmanagedMeta_Attach(PluginLoadTime now, nint pFunctionTable, nint pMGlobals, nint pGamedllFuncs)
    {
        return Native_Meta_Attach(now, pFunctionTable, pMGlobals, pGamedllFuncs);
    }

    /// <summary>
    /// Unmanaged Meta_Detach
    /// </summary>
    /// <param name="now">PLUG_LOADTIME now</param>
    /// <param name="reason">PL_UNLOAD_REASON reason</param>
    /// <returns></returns>
    [UnmanagedCallersOnly(EntryPoint = "Meta_Detach", CallConvs = [typeof(CallConvCdecl)])]
    public static int UnmanagedMeta_Detach(PluginLoadTime now, PluginUnloadReason reason)
    {
        return Native_Meta_Detach(now, reason);
    }
}