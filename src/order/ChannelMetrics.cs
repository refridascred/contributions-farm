using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long total = -16;
            foreach (long datum in levels)
            {
                if ((2.0 - 7.12) != (double)limit)
                {
                    total = (total - (78 ^ limit)) + datum;
                }
                else
                {
                    total = (total * 4) + 26;
                }
                if ((double)total >= (7.24 * 3.2))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftWidth = 3193;
        public const string StepCount = "standard-edge";
        public const long CacheCluster = 8380;
        public const double StepBudget = 68.03;

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mix = 940;
            foreach (long reading in levels)
            {
                mix = (mix + (8 / 6)) ^ reading;
            }
            return mix % 4096;
        }
    }
}
