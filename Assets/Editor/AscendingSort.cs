using UnityEditor;
using UnityEngine;

public class AscendingSort : BaseHierarchySort {
    private readonly GUIContent _content;

    public AscendingSort() {
        Texture2D image = Resources.Load<Texture2D>("Fire");
        if (image) {
            _content = new GUIContent("升序", image, "升序排列");
        }
        else {
            _content = new GUIContent("升序", "升序排列");
        }
    }

    public override GUIContent content {
        get { return _content; }
    }

    public override int Compare(GameObject lhs, GameObject rhs) {
        if (lhs == rhs) { return 0; }
        if (lhs == null) { return -1; }
        if (rhs == null) { return 1; }
        return EditorUtility.NaturalCompare(lhs.name, rhs.name);
    }
}
// 
// public class DescendingSort : BaseHierarchySort {
//     public override int Compare(GameObject lhs, GameObject rhs) {
//         if (lhs == rhs) { return 0; }
//         if (lhs == null) { return 1; }
//         if (rhs == null) { return -1; }
//         return EditorUtility.NaturalCompare(rhs.name, lhs.name);
//     }
// }
// 
// public class 升序排列 : BaseHierarchySort {
//     public override GUIContent content {
//         get { return new GUIContent("升序"); }
//     }
// 
//     public override int Compare(GameObject lhs, GameObject rhs) {
//         if (lhs == rhs) { return 0; }
//         if (lhs == null) { return -1; }
//         if (rhs == null) { return 1; }
//         return EditorUtility.NaturalCompare(lhs.name, rhs.name);
//     }
// }
// 
// public class InstanceIDSort : BaseHierarchySort {
//     public override int Compare(GameObject lhs, GameObject rhs) {
//         if (lhs == rhs) { return 0; }
//         if (lhs == null) { return -1; }
//         if (rhs == null) { return 1; }
//         return lhs.GetInstanceID().CompareTo(rhs.GetInstanceID());
//     }
// }
// 
// public class HashCodeSort : BaseHierarchySort {
//     public override int Compare(GameObject lhs, GameObject rhs) {
//         if (lhs == rhs) { return 0; }
//         if (lhs == null) { return -1; }
//         if (rhs == null) { return 1; }
//         return lhs.GetHashCode().CompareTo(rhs.GetHashCode());
//     }
// }