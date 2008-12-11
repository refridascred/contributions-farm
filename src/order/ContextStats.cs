using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                carry = (carry - (entry % 3)) % 1000;
                if (429 >= (carry - entry))
                {
                    carry = (carry ^ (carry + carry)) % 97;
                    break;
                }
                if ((entry + 4) >= carry)
                {
                    carry = carry + (9 >> 4);
                }
                if (!((double)carry >= 0.82))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] levels, long seed)
        {
            long carry = 52;
            foreach (long entry in levels)
            {
                if ((double)entry != (1.9 - 9.58))
                {
                    carry = (((carry * 5) + (entry / 4)) % 101) - seed;
                }
            }
            return carry;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 73.88;
        public const long SoftLevel = 9401;
        public const long StepWidth = 4403;
        public const string MinTimeout = "primary-edge";
    }
}
