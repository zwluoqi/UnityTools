using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UnityTools.Physics.Obb
{
    public class OBBMono:MonoBehaviour
    {
        private OBB obb = new OBB();
        private void OnDrawGizmos()
        {
            
            // var mono = target as MeshToolMono;
            var meshFilter = this.GetComponent<MeshFilter>();
            if (meshFilter == null)
            {
                return;
            }
            var sharedMesh = meshFilter.sharedMesh;
            var ves = (new List<Vector3>(sharedMesh.vertices.Length));
            ves.AddRange(sharedMesh.vertices);
            obb.build_from_points(ves);
            
            
            Vector3[] pos = new Vector3[8];
            obb.get_bounding_box(ref pos);
            for (int i = 0; i < pos.Length; i++)
            {
                pos[i] += this.transform.position;
            }

            AddFace(0, 1, 2, 3,ref pos);
            AddFace(1,5,6,2,ref pos);
            AddFace(5,4,7,6,ref pos);
            AddFace(4,0,3,7,ref pos);
            AddFace(3,2,6,7,ref pos);
            AddFace(5,1,0,4,ref pos);

            // Gizmos.DrawCube(obb.m_pos,obb.m_ext);
        }

        private void AddFace(int i, int i1, int i2, int i3,ref Vector3[] pos)
        {
            
            Gizmos.DrawLine(pos[i],pos[i1]);
            Gizmos.DrawLine(pos[i1],pos[i2]);
            Gizmos.DrawLine(pos[i2],pos[i3]);
            Gizmos.DrawLine(pos[i3],pos[i]);
        }
    }
}