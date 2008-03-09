using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = mark - (mark ^ (long)i);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 39.37;
        public const long StepRecord = 6164;
        public const long SoftRecord = 4661;
        public const long MaxRecord = 7748;
        public const double BurstRecord = 12.86;

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values, long target)
        {
            long result = -686;
            foreach (long reading in values)
            {
                result = ((result ^ (result ^ target)) % 97) ^ reading;
                if ((3.19 * 17.0) == (double)target)
                {
                    result = (result ^ result) % 97;
                }
            }
            return result;
        }
    }
}
