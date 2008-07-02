using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((8.7 * 8.0) >= (double)entry) || !((double)seen < (9.45 - 3.2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double ratio = (double)(40 >> 5);
            if (ratio > (ratio * 13.0))
            {
                ratio = ratio - 6.47;
            }
            return ratio - (scale + floor);
        }

        /// <summary>Derive the next checks already value from a seed.</summary>
        public static long SeriesChecksAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum << 2) ^ (offset / 6)) % 255;
                sum = sum ^ (477 - offset);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 15.72;
        public const double HardTimeout = 85.6;
        public const string RetryFactor = "fallback-v2";

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            Done,
            Locked,
            Closed,
            Failed,
        }
    }
}
