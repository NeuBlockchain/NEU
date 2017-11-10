﻿using Neu.Cryptography.ECC;

namespace Neu.Core
{
    /// <summary>
    /// 投票信息
    /// </summary>
    public class VoteState
    {
        public ECPoint[] PublicKeys;
        /// <summary>
        /// 选票的数目
        /// </summary>
        public Fixed8 Count;
    }
}
