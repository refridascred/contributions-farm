using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double ratio = (bias + offset) - (4.32 * 8.76);
            if (ratio <= (double)(-5))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (double)96;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 6.6) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Audit command account readings against a rule.</summary>
        public static long TallyCommandAccountMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum > 7.73))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
