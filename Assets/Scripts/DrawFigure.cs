using UnityEngine;
using System.Collections;
using System;

public class DrawFigure : MonoBehaviour
{
    public Vector3[] Vertex = new Vector3[]
    {
         new Vector3(0,0,0),new Vector3(3,0,0),new Vector3(0,3,0),new Vector3(3,3,0) // 4 VERTEXES! (Plane has 4 vertexes)
    };

    public Vector2[] UV_MaterialDisplay = new Vector2[]
    {
         new Vector2(0,0),new Vector2(3,0),new Vector2(0,3),new Vector2(3,3) // 4 UV with all directions! (Plane has 4 uvMaps)
    };

    public int[] Triangles = new int[6]; // 2 Triangle combinations (2*3=6 verticles/vertexes) + (Triangle has 3 edges & 3 vertexes & 1 face) In plane are 2 triangles for make cubed plane! (Plane has 2 triangles)

    public Material material;

    void Start()
    {

        Triangles[0] = 0;
        Triangles[1] = 3;
        Triangles[2] = 1;

        Triangles[3] = 0;
        Triangles[4] = 2;
        Triangles[5] = 3;

        Mesh mesh = new Mesh();
        transform.GetComponent<MeshFilter>();

        if (!transform.GetComponent<MeshFilter>() || !transform.GetComponent<MeshRenderer>()) //If you will havent got any meshrenderer or filter
        {
            transform.gameObject.AddComponent<MeshFilter>();
            transform.gameObject.AddComponent<MeshRenderer>();
        }

        transform.GetComponent<MeshFilter>().mesh = mesh;

        mesh.name = "MyOwnObject";

        mesh.vertices = Vertex; //Just do this... Use Logic...
        mesh.triangles = Triangles;
        mesh.uv = UV_MaterialDisplay;

        mesh.RecalculateNormals();
        mesh.Optimize();

    }

}
