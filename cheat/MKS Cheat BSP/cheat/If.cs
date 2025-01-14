using System;
using System.Runtime.InteropServices;

namespace cheat
{
	// Token: 0x02000018 RID: 24
	public class If
	{
		// Token: 0x06000032 RID: 50
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		private static extern bool SetCursorPos(int x, int y);

		// Token: 0x06000033 RID: 51
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		private static extern bool GetCursorPos(out global::cheat.If.Weg lpMousePoint);

		// Token: 0x06000034 RID: 52
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		// Token: 0x06000035 RID: 53 RVA: 0x000030BC File Offset: 0x000012BC
		public static void SetCursorPosition(int x, int y)
		{
			global::cheat.If.SetCursorPos(x, y);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000030D4 File Offset: 0x000012D4
		public static void SetCursorPosition(global::cheat.If.Weg point)
		{
			global::cheat.If.SetCursorPos(point.Ney, point.beR);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000030F4 File Offset: 0x000012F4
		public static global::cheat.If.Weg GetCursorPosition()
		{
			global::cheat.If.Weg weg;
			if (!global::cheat.If.GetCursorPos(out weg))
			{
				weg = new global::cheat.If.Weg(0, 0);
			}
			return weg;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003118 File Offset: 0x00001318
		public static void MouseEvent(global::cheat.If.Nel value)
		{
			global::cheat.If.Weg cursorPosition = global::cheat.If.GetCursorPosition();
			global::cheat.If.mouse_event((int)value, cursorPosition.Ney, cursorPosition.beR, 0, 0);
		}

		// Token: 0x02000019 RID: 25
		[global::System.Flags]
		public enum Nel
		{

		}

		// Token: 0x0200001A RID: 26
		public struct Weg
		{
			// Token: 0x0600003A RID: 58 RVA: 0x00003144 File Offset: 0x00001344
			public Weg(int x, int y)
			{
				this.Ney = x;
				this.beR = y;
			}

			// Token: 0x0400001A RID: 26
			public int Ney;

			// Token: 0x0400001B RID: 27
			public int beR;
		}
	}
}
