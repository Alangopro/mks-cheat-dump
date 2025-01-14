using System;
using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000004 RID: 4
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Method | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[global::Microsoft.CodeAnalysis.Embedded]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	internal sealed class NullableContextAttribute : global::System.Attribute
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000026D8 File Offset: 0x000008D8
		public NullableContextAttribute(byte byte_0)
		{
			this.Flag = byte_0;
		}

		// Token: 0x04000003 RID: 3
		public readonly byte Flag;
	}
}
