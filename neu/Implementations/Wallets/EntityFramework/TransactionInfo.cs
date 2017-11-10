using System;
using CoreTransaction = Neu.Core.Transaction;

namespace Neu.Implementations.Wallets.EntityFramework
{
    public class TransactionInfo
    {
        public CoreTransaction Transaction;
        public uint? Height;
        public DateTime Time;
    }
}
