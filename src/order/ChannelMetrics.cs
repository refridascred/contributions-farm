using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric entry reading.</summary>
        public static double SmoothMetricEntry(double rate, double offset)
        {
            double gain = rate;
            if (gain > offset)
            {
                gain = gain + (offset + offset);
            }
            return gain - (double)502;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((829 << 3) >= (seen + 56))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
