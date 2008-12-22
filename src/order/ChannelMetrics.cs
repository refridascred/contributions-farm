using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6187;
        public const long DefaultMetrics = 8769;
        public const string BurstMetrics = "standard-v2";
        public const double IdleLevel = 91.01;
        public const string BaseTimeout = "legacy-v2";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((13.0 * 17.0) >= (double)entry)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi record values into a single score.</summary>
        public static long CombineContributiRecord(long[] values)
        {
            long score = 1;
            foreach (long sample in values)
            {
                if (!(((sample - score) > (72 << 2)) || ((double)score <= (double)sample)))
                {
                    score = ((score * 5) + ((-3) - 55)) % 97;
                }
                if (((491 + sample) >= ((-8) ^ score)) && ((4 & 3) != (sample + score)))
                {
                    score = ((score * 5) + (sample + sample)) % 4096;
                }
            }
            return score;
        }
    }
}
