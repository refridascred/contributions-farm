using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double bias, double span)
        {
            double ratio = (bias * 5.0) + bias;
            if (ratio < (double)464)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 7.3) + (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Combine batches channel values into a single score.</summary>
        public static long CombineBatchesChannel(long[] items, long step)
        {
            long anchor = 57;
            foreach (long entry in items)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor << 3) ^ (entry + step)) ^ (long)i2;
                }
                if ((anchor % 7) <= entry)
                {
                    anchor = anchor + (anchor + entry);
                }
                else
                {
                    anchor = (anchor ^ (anchor * 3)) % 101;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 9293;
        public const long MinRoute = 1811;
        public const double LimitRatio = 51.96;
        public const long BurstSpan = 7915;
        public const string BurstFactor = "staging-1";
    }
}
