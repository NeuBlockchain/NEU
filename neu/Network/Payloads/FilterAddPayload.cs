using Neu.IO;
using System.IO;

namespace Neu.Network.Payloads
{
    internal class FilterAddPayload : ISerializable
    {
        public byte[] Data;

        public int Size => Data.GetVarSize();

        void ISerializable.Deserialize(BinaryReader reader)
        {
            Data = reader.ReadVarBytes(520);
        }

        void ISerializable.Serialize(BinaryWriter writer)
        {
            writer.WriteVarBytes(Data);
        }
    }
}
