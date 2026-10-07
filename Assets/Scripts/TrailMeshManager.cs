using System;
using UnityEngine;
using UnityEditor;

public class TrailMeshManager : MonoBehaviour
{
    [SerializeField] private TrailRenderer trailRenderer;

    [ContextMenu("Sauvegarder le mesh")]
    private void Sauvegarder()
    {
        Mesh mesh = new Mesh();
        trailRenderer.BakeMesh(mesh, true);
        AssetDatabase.CreateAsset(mesh, "Assets/TrailMesh.asset");
    }
}
