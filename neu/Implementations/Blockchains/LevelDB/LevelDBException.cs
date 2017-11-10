using System.Data.Common;

namespace Neu.Implementations.Blockchains.LevelDB
{
    internal class LevelDBException : DbException
    {
        internal LevelDBException(string message)
            : base(message)
        {
        }
    }
}
