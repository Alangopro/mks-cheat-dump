using System;
using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000003 RID: 3
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Event | global::System.AttributeTargets.Parameter | global::System.AttributeTargets.ReturnValue | global::System.AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[global::Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : global::System.Attribute
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002698 File Offset: 0x00000898
		public NullableAttribute(byte byte_0)
		{
			this.NullableFlags = new byte[] { byte_0 };
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000026BC File Offset: 0x000008BC
		public NullableAttribute(byte[] byte_0)
		{
			this.NullableFlags = byte_0;
		}

		// Token: 0x04000002 RID: 2
		public readonly byte[] NullableFlags;
	}
}
