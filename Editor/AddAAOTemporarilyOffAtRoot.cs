#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class CustomGameObjectCreator
{
    [MenuItem("GameObject/Ill_tools/AAOTemporarilyOff At Root", false, 10)]
    static void AddMyObjectAtRoot()
    {
        // シーン内に "AAOTemporarilyOff" という名前のオブジェクトが存在するかチェック
        GameObject existing = GameObject.Find("AAOTemporarilyOff");
        if (existing != null)
            return;

        GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(
            AssetDatabase.GUIDToAssetPath("7304e219354266a4ba3c1619e6fe8e40")
        );
        if (prefab == null)
            return;

        // パッケージ内のPrefabをシーンにインスタンス化（ルートに配置される）
        GameObject instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
        if (instance == null)
            return;

        Undo.RegisterCreatedObjectUndo(instance, "Instantiate AAOTemporarilyOff");
    }
}
#endif
