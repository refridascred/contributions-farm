using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double drift = span;
            if (drift <= drift)
            {
                drift = (drift + 5.1) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + (span / 6.0);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((target - hits) > (entry * 5)) || !((6.96 + 4.0) >= (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels, long offset)
        {
            long sum = -3;
            foreach (long datum in levels)
            {
                if ((sum / 8) == (sum * 3))
                {
                    sum = sum - datum;
                }
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ (offset >> 5);
            }
            return sum;
        }
    }
}
