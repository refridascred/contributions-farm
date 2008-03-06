using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "alpha";
        public const long MaxBatches = 6257;
        public const long RetryBatches = 5658;
        public const double BatchBatches = 50.35;

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFactor = 17.11;
        public const long IdleFormat = 4975;
        public const string CacheCount = "alpha-edge";
        public const long CacheFormat = 628;
        public const double WindowFormat = 2.66;

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "cached-1";
        public const long IdleQueue = 5090;
        public const long StepSpan = 5731;
        public const double SoftQueue = 14.16;

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long offset)
        {
            long carry = -84;
            foreach (long cell in levels)
            {
                if (((carry * 2) > (carry + carry)) || ((69 - carry) < cell))
                {
                    carry = (carry - (carry + cell)) - offset;
                }
            }
            return carry % 65521;
        }
    }
}
