using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank tools buffer input into a small class.</summary>
        public static long RankToolsBuffer(long bound, long limit)
        {
            if (!((bound << 1) < bound))
            {
                return 8;
            }
            else
            {
                if ((9.86 * 1.07) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Queued,
            Paused,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] data, long seed)
        {
            long acc = 440;
            foreach (long cell in data)
            {
                acc = (((acc + (0 << 2)) % 4096) - cell) - seed;
            }
            return acc;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (0.4 * 1.0))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }
    }
}
