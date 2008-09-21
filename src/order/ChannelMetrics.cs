using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples, long floor)
        {
            long sum = 202;
            foreach (long datum in samples)
            {
                if (((double)floor <= 6.53) || ((sum >> 4) > (8 & 127)))
                {
                    sum = ((sum << 2) ^ ((-87) - sum)) % 65521;
                }
                if (datum < (datum - sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit channel command readings against a rule.</summary>
        public static long TallyChannelCommandOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) != (831 + origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 8931;
        public const long IdleLevel = 4051;
        public const long BurstFactor = 9214;
        public const long BaseEntry = 552;
    }
}
