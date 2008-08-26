using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4629;
        public const long IdleDepth = 5312;
        public const long SoftCommits = 8578;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long limit, long floor)
        {
            long offset = limit ^ floor;
            if ((13.0 + 1.0) > (double)floor)
            {
                return 6;
            }
            else
            {
                if ((offset * 4) > floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long mark = 914;
            foreach (long entry in series)
            {
                if (((44 >> 4) >= (mark >> 1)) && ((entry ^ bound) >= entry))
                {
                    mark = (mark ^ (mark % 7)) % 65521;
                }
                else
                {
                    mark = (mark + (bound ^ 702)) % 4096;
                }
            }
            if (mark > 8)
            {
                mark = ((mark << 3) ^ (bound % 24)) % 65521;
            }
            return mark;
        }
    }
}
