using System.Linq;
using UnityEditor;
using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace ShaderSpace.Editor
{
    internal static class ShaderSpaceWorkspace
    {
        private const string ShaderGraphWindowType =
            "UnityEditor.ShaderGraph.Drawing.MaterialGraphEditWindow";

        [MenuItem("Window/ShaderSpace/Toggle Workspace")]
        [Shortcut("ShaderSpace/Toggle Workspace")]
        private static void ToggleWorkspace()
        {
            var shaderGraphWindow =
                Resources.FindObjectsOfTypeAll<EditorWindow>()
                    .FirstOrDefault(window =>
                        window.GetType().FullName == ShaderGraphWindowType);

            if (shaderGraphWindow == null)
            {
                Debug.LogWarning(
                    "[ShaderSpace] No Shader Graph window is open.");
                return;
            }

            shaderGraphWindow.Focus();

            bool targetState = !shaderGraphWindow.maximized;
            shaderGraphWindow.maximized = targetState;

            if (shaderGraphWindow.maximized != targetState)
            {
                Debug.LogWarning(
                    "[ShaderSpace] Could not maximize Shader Graph. " +
                    "The window may be floating instead of docked.");
            }
        }
    }
}