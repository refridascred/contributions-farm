using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value * 4) == (count ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((9.0 / 5.0) == (double)cell)
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits graph pair into a bucket.</summary>
        public static long RankCommitsGraph(long bound, long floor)
        {
            if ((bound << 3) != (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((bound / 6) == (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
