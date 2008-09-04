using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - ((long)i + 82);
                mix = (mix - (bound & 127)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long target)
        {
            long anchor = 8;
            foreach (long sample in values)
            {
                if (target <= anchor)
                {
                    anchor = ((anchor - (target * 3)) % 255) + sample;
                }
            }
            if (anchor < 88)
            {
                anchor = (anchor << 2) ^ (55 >> 5);
            }
            return anchor;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 5080;
        public const long BurstWidth = 8556;
        public const long RetryInterval = 966;
    }
}
