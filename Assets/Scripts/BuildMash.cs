using UnityEngine;
using System.Collections;

public class BuildMash : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = mf.mesh;

        //verticies
        Vector3[] vericies = new Vector3[]
        {
            //front face 
             new Vector3(0,0,0),
            new Vector3(1,0,0),
            new Vector3(0,1,0),
            new Vector3(1,1,0)


        };

        //triangles
        int[] triangles = new int[]
        {
           0,2,3,
           3,1,0
       };

        //uvs
        Vector2[] uvs = new Vector2[]
        {
            new Vector2(0,1),
            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(1, 1)
        };

        mesh.Clear();
        mesh.vertices = vericies;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
