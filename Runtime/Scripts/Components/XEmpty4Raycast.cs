﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace TinaX.UIKit
{
    [AddComponentMenu("TinaX/UIKit/Components/X Empty4Raycast")]
    public class XEmpty4Raycast : MaskableGraphic
    {
        protected XEmpty4Raycast()
        {
            useLegacyMeshGeneration = false;
        }

        protected override void OnPopulateMesh(VertexHelper vh)
        {
            vh.Clear();
        }


#if UNITY_EDITOR
        [MenuItem("GameObject/UI/TinaX/xEmpty4Raycast", false, 1)]
        [MenuItem("GameObject/TinaX/UIKit/xEmpty4Raycast", false, 1)]
        static void AddxE4R()
        {
            if (Selection.activeTransform != null)
            {
                if (Selection.activeTransform.GetComponentInParent<Canvas>())
                {
                    var go_name = "xEmpty4Raycast";
                    if (Selection.activeTransform.Find(go_name) != null)
                    {
                        var index = 1;

                        while (Selection.activeTransform.Find("xEmpty4Raycast" + index.ToString()) != null)
                        {
                            index++;
                        }
                        go_name = "xEmpty4Raycast" + index.ToString();
                    }

                    var go = Selection.activeGameObject
                        .CreateGameObject(go_name, typeof(XEmpty4Raycast));
                    var xe4r = go.GetComponent<XEmpty4Raycast>();
                    xe4r.rectTransform.anchoredPosition3D = Vector3.zero;
                    xe4r.rectTransform.localScale = Vector3.one;
                    xe4r.rectTransform.sizeDelta = new Vector2(100, 100);

                    
                    Selection.activeTransform = go.transform;
                }
                else
                {
                    Debug.LogError("Component \"XEmpty4Raycast\" only can used in UGUI gameobject.");
                }
                
            }
        }
#endif

    }

}
