// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateBotInlineQuery : TLUpdateBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Geo = (1 << 0),
		}

		public bool HasGeo { get { return Flags.HasFlag(Flag.Geo); } set { Flags = value ? (Flags | Flag.Geo) : (Flags & ~Flag.Geo); } }

		public Flag Flags { get; set; }
		public Int64 QueryId { get; set; }
		public Int32 UserId { get; set; }
		public String Query { get; set; }
		public TLGeoPointBase Geo { get; set; }
		public String Offset { get; set; }

		public TLUpdateBotInlineQuery() { }
		public TLUpdateBotInlineQuery(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateBotInlineQuery; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			QueryId = from.ReadInt64();
			UserId = from.ReadInt32();
			Query = from.ReadString();
			if (HasGeo) Geo = TLFactory.Read<TLGeoPointBase>(from);
			Offset = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt64(QueryId);
			to.WriteInt32(UserId);
			to.WriteString(Query ?? string.Empty);
			if (HasGeo) to.WriteObject(Geo);
			to.WriteString(Offset ?? string.Empty);
		}

		private void UpdateFlags()
		{
			HasGeo = Geo != null;
		}
	}
}