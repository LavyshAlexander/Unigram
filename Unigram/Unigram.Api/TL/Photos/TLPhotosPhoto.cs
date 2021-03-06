// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Photos
{
	public partial class TLPhotosPhoto : TLObject 
	{
		public TLPhotoBase Photo { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLPhotosPhoto() { }
		public TLPhotosPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PhotosPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			Photo = TLFactory.Read<TLPhotoBase>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Photo);
			to.WriteObject(Users);
		}
	}
}