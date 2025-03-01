#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class CustomGameObjectCreator
{
    [MenuItem("GameObject/illusive_tools/Add AAOBlocker At Root", false, 10)]
    static void AddMyObjectAtRoot()
    {
        // シーン内に "AAOBlocker" という名前のオブジェクトが存在するかチェック
        GameObject existing = GameObject.Find("AAOBlocker");
        if (existing != null)
            return;
        // パッケージ内のPrefabのパス（必要に応じて修正してください）
        string prefabPath = "Packages/jp.illusive-isc.aao-blocker/AAOBlocker.prefab";
        GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
        if (prefab == null)
            return;

        // パッケージ内のPrefabをシーンにインスタンス化（ルートに配置される）
        GameObject instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
        if (instance == null)
            return;

        Undo.RegisterCreatedObjectUndo(instance, "Instantiate AAOBlocker");
    }
}
#endif
