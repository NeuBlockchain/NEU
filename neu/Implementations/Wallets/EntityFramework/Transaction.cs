using Neu.Core;
using System;

namespace Neu.Implementations.Wallets.EntityFramework
{
    internal class Transaction
    {
        public byte[] Hash { get; set; }
        public TransactionType Type { get; set; }
        public byte[] RawData { get; set; }
        public uint? Height { get; set; }
        public DateTime Time { get; set; }
    }
}
