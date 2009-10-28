//
// SRationalIFDEntry.cs:
//
// Author:
//   Ruben Vermeersch (ruben@savanne.be)
//   Mike Gemuende (mike@gemuende.de)
//
// Copyright (C) 2009 Ruben Vermeersch
//
// This library is free software; you can redistribute it and/or modify
// it  under the terms of the GNU Lesser General Public License version
// 2.1 as published by the Free Software Foundation.
//
// This library is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307
// USA
//

namespace TagLib.IFD.Entries
{
	/// <summary>
	///    Contains a SRATIONAL value.
	/// </summary>
	public class SRationalIFDEntry : IFDEntry
	{
		public ushort Tag { get; private set; }
		public SRational Value { get; private set; }

		public SRationalIFDEntry (ushort tag, SRational value)
		{
			Tag = tag;
			Value = value;
		}

		public ByteVector Render (bool is_bigendian, uint offset, out ushort type, out uint count)
		{
			type = (ushort) IFDEntryType.SRational;
			count = 1;

			ByteVector data = new ByteVector ();
			data.Add (ByteVector.FromInt (Value.Numerator, is_bigendian));
			data.Add (ByteVector.FromInt (Value.Denominator, is_bigendian));

			return data;
		}
	}
}
