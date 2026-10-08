using System.Collections;
using UnityEngine;

public class TrailMeshManager : MonoBehaviour
{
    [SerializeField] private TrailRenderer trailRenderer;

    private Mesh mesh;
    private MeshFilter meshFilter;
    private MeshCollider meshCollider;
    [SerializeField] private float refreshRate = 1f;
    [SerializeField] private Camera camera;

    private void Awake()
    {
        mesh = new Mesh();

        meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null)
            meshFilter = gameObject.AddComponent<MeshFilter>();

        meshCollider = GetComponent<MeshCollider>();
        if (meshCollider == null)
            meshCollider = gameObject.AddComponent<MeshCollider>();
    }

    private void Start()
    {
        StartCoroutine(SauvegarderCoroutine());
    }

    private void Sauvegarder()
    {
        mesh.Clear();
        Debug.Log("Ok");
        trailRenderer.BakeMesh(mesh, camera, true);
        

        meshFilter.sharedMesh = mesh;
        meshCollider.sharedMesh = null; 
        meshCollider.sharedMesh = mesh;
    }

    private IEnumerator SauvegarderCoroutine()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(refreshRate);
            Sauvegarder();
        }
    }
}