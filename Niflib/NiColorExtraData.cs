#if OpenTK
using OpenTK.Graphics;
#elif SharpDX
using SharpDX;
#endif
using System;
using System.IO;

namespace Niflib
{
	public class NiColorExtraData : NiExtraData
	{
		public Color4 Data;

		public NiColorExtraData(NiFile file, BinaryReader reader) : base(file, reader)
		{
			this.Data = reader.ReadColor4();
		}
	}
}