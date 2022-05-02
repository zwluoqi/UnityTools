using UnityEditor;

namespace UnityTools.ScriptedObjectUpdate
{
    [CustomEditor(typeof(DemoSettingMono))]
    public class DemoSettingMonoEditor : Editor
    {
        private SettingEditor<LSystemMesh> shapeEdirot;

        private void OnEnable()
        {
            shapeEdirot = new SettingEditor<LSystemMesh>();
            shapeEdirot.OnEnable(this);
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            shapeEdirot.OnInspectorGUI(this);
        }
    }
}