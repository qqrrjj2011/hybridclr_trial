using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditorInternal;
using UnityEngine;

[CreateAssetMenu(fileName = "HybridCLRGlobalSettings", menuName = "HybridCLR/GlobalSettings")]
public class HybridCLRGlobalSettings : ScriptableObject
{
    [Header("����HybridCLR���")]
    public bool enable = true;

    [Header("��gitee clone�������")]
    public bool cloneFromGitee = true; // false ���github����ȡ

    [Header("�ȸ���Assembly Definition Modules")]
    public AssemblyDefinitionAsset[] hotfixAssemblyDefinitions;

    [Header("�ȸ���dlls")]
    public string[] hotfixAssemblies;

    [Header("�Զ�ɨ�����ɵ�link.xml·��")]
    public string outputLinkFile = "LinkGenerator/link.xml";

    [Header("Ԥ��MonoPInvokeCallbackAttribute��������")]
    public int pinvokeReverseWrapperCount = 10;

    [Header("MethodBridge����������������")]
    public int maxMethodBridgeGenericIteration = 4;

    [Header("�ȸ���dll���Ŀ¼�����HybridCLRDataĿ¼��")]
    public string hotfixDllOutputDir = "HotFixDlls";

    [Header("HybridCLRDataĿ¼����Թ���Ŀ¼��")]
    public string hybridCLRDataDir = "HybridCLRData";

    [Header("�ü����AOT assembly���Ŀ¼")]
    public string strippedAssemblyDir = "AssembliesPostIl2CppStrip";
}