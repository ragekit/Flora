using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeshBuilder {

	public List<Vector3> vertices { get; private set;}
	public List<Vector3> normals { get; private set;}

	public List<Vector2> uv { get; private set;}
	public List<int> indices { get; private set;}

	public MeshBuilder()
	{
		vertices = new List<Vector3> ();
		normals = new List<Vector3> ();
		uv = new List<Vector2> ();
		indices = new List<int> ();
	}

	public void AddTriangle(int i1,int i2,int i3)
	{
		indices.Add (i1);
		indices.Add (i2);
		indices.Add (i3);
	}

	public void BuildQuad()
	{

	}

	public Mesh CreateMesh()
	{
		Mesh m = new Mesh ();
		m.vertices = vertices.ToArray();
		m.triangles = indices.ToArray ();

		if(normals.Count == vertices.Count)
		{
			m.normals = normals.ToArray();
		}

		if (uv.Count == vertices.Count) 
		{
			m.uv = uv.ToArray();		
		}

		m.RecalculateBounds ();

		return m;

	}

}
