using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long total = 187;
            foreach (long datum in samples)
            {
                if (total > (total ^ datum))
                {
                    total = (total * 4) + (datum * 5);
                }
            }
            return total;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((17.0 * 2.1) < (double)item)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double span)
        {
            double gain = bias;
            if (gain >= (span / 5.0))
            {
                gain = gain + (gain / 7.0);
            }
            else
            {
                gain = gain + (double)368;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)138;
        }
    }
}
