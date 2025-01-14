using System;
using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000003 RID: 3
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Microsoft.CodeAnalysis.Embedded]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Event | global::System.AttributeTargets.Parameter | global::System.AttributeTargets.ReturnValue | global::System.AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : global::System.Attribute
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public NullableAttribute(byte A_1)
		{
			this.NullableFlags = new byte[] { A_1 };
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002070 File Offset: 0x00000270
		public NullableAttribute(byte[] A_1)
		{
			this.NullableFlags = A_1;
		}

		// Token: 0x04000001 RID: 1
		public readonly byte[] NullableFlags;
	}
}
