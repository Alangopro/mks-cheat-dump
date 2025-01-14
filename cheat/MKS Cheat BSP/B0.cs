using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000017 RID: 23
[global::System.Runtime.CompilerServices.Nullable(0)]
[global::System.Runtime.CompilerServices.NullableContext(1)]
internal class B0
{
	// Token: 0x06000028 RID: 40 RVA: 0x000022F3 File Offset: 0x000004F3
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	public static global::UnityEngine.GUIStyle J7()
	{
		return global::B0.Yp;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000022FA File Offset: 0x000004FA
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	public static void IZ(global::UnityEngine.GUIStyle guistyle_0)
	{
		global::B0.Yp = guistyle_0;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002302 File Offset: 0x00000502
	public static global::UnityEngine.Color oV()
	{
		return global::UnityEngine.GUI.color;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002E4C File Offset: 0x0000104C
	public static void UC(global::UnityEngine.Color color_0)
	{
		global::UnityEngine.GUI.color = color_0;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002E60 File Offset: 0x00001060
	public static void DrawString(global::UnityEngine.Vector2 position, string label, global::UnityEngine.Color color, bool centered = true)
	{
		global::UnityEngine.GUIContent guicontent = new global::UnityEngine.GUIContent(label);
		global::UnityEngine.Vector2 vector = global::B0.Yp.CalcSize(guicontent);
		global::UnityEngine.GUI.color = color;
		global::UnityEngine.GUI.Label(new global::UnityEngine.Rect((!centered) ? position : (position - vector / 2f), vector), guicontent);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002EB0 File Offset: 0x000010B0
	public static void DrawLine(global::UnityEngine.Vector2 pointA, global::UnityEngine.Vector2 pointB, global::UnityEngine.Color color, float width)
	{
		global::B0.U2 = global::UnityEngine.GUI.matrix;
		global::UnityEngine.GUI.color = color;
		float num = global::UnityEngine.Vector3.Angle(pointB - pointA, global::UnityEngine.Vector2.right);
		if (pointA.y > pointB.y)
		{
			num = -num;
		}
		global::UnityEngine.GUIUtility.ScaleAroundPivot(new global::UnityEngine.Vector2((pointB - pointA).magnitude, width), new global::UnityEngine.Vector2(pointA.x, pointA.y + 0.5f));
		global::UnityEngine.GUIUtility.RotateAroundPivot(num, pointA);
		global::UnityEngine.GUI.DrawTexture(new global::UnityEngine.Rect(pointA.x, pointA.y, 1f, 1f), global::B0.I8);
		global::UnityEngine.GUI.matrix = global::B0.U2;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002F68 File Offset: 0x00001168
	public static void DrawBox(float x, float y, float w, float h, global::UnityEngine.Color color, float thickness)
	{
		global::B0.DrawLine(new global::UnityEngine.Vector2(x, y), new global::UnityEngine.Vector2(x + w, y), color, thickness);
		global::B0.DrawLine(new global::UnityEngine.Vector2(x, y), new global::UnityEngine.Vector2(x, y + h), color, thickness);
		global::B0.DrawLine(new global::UnityEngine.Vector2(x + w, y), new global::UnityEngine.Vector2(x + w, y + h), color, thickness);
		global::B0.DrawLine(new global::UnityEngine.Vector2(x, y + h), new global::UnityEngine.Vector2(x + w, y + h), color, thickness);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002FE4 File Offset: 0x000011E4
	public static void smethod_0(global::UnityEngine.Vector2 v1, global::UnityEngine.Vector2 v2, global::UnityEngine.Vector2 v3, global::UnityEngine.Vector2 v4, global::UnityEngine.Vector2 v5, global::UnityEngine.Vector2 v6, global::UnityEngine.Vector2 v7, global::UnityEngine.Vector2 v8, global::UnityEngine.Color color, float thickness)
	{
		global::B0.DrawLine(v1, v2, color, thickness);
		global::B0.DrawLine(v1, v3, color, thickness);
		global::B0.DrawLine(v2, v4, color, thickness);
		global::B0.DrawLine(v4, v3, color, thickness);
		global::B0.DrawLine(v1, v5, color, thickness);
		global::B0.DrawLine(v2, v6, color, thickness);
		global::B0.DrawLine(v3, v7, color, thickness);
		global::B0.DrawLine(v4, v8, color, thickness);
		global::B0.DrawLine(v5, v6, color, thickness);
		global::B0.DrawLine(v6, v8, color, thickness);
		global::B0.DrawLine(v7, v8, color, thickness);
		global::B0.DrawLine(v7, v5, color, thickness);
	}

	// Token: 0x04000016 RID: 22
	public static global::UnityEngine.Texture2D I8 = new global::UnityEngine.Texture2D(1, 1);

	// Token: 0x04000017 RID: 23
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	private static global::UnityEngine.GUIStyle Yp = new global::UnityEngine.GUIStyle(global::UnityEngine.GUI.skin.label);

	// Token: 0x04000018 RID: 24
	private static global::UnityEngine.Matrix4x4 U2 = global::UnityEngine.GUI.matrix;
}
