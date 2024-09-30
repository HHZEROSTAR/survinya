using UnityEngine;
using System.Collections.Generic;

namespace Gameplay.Stat.Mono
{
    public class DebuggerMono : MonoBehaviour
    {
        private readonly Dictionary<string, string> debugInfo = new Dictionary<string, string>();

        private GUIStyle style;
        private Camera   cachedCamera;

        private void Awake()
        {
            cachedCamera = Camera.main;
        }

        private void Start()
        {
            style = new GUIStyle
            {
                normal    = { textColor = Color.white },
                fontSize  = 24,
                fontStyle = FontStyle.Bold,
                alignment = TextAnchor.UpperCenter
            };
        }

        public void SetDebugInfo(string key, string value)
        {
            debugInfo[key] = value;
        }

        private void OnGUI()
        {
            var screenPosition = cachedCamera.WorldToScreenPoint(transform.position);
            screenPosition.y = Screen.height - screenPosition.y;

            var yOffset = -50f;
            foreach (var kvp in debugInfo)
            {
                GUI.Label(new Rect(screenPosition.x - 50, screenPosition.y + yOffset, 100, 20), $"{kvp.Key}: {kvp.Value}", style);
                yOffset += 25f;
            }
        }
    }
}
