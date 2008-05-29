using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((double)anchor <= (double)8)
                {
                    break;
                }
                anchor = (anchor ^ (90 / 6)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Synced,
            New,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + count) <= (42 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double mean = (double)1 * 0.66;
            if (mean >= span)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (0.56 + mean)) + (double)(long)i;
            }
            return mean - (scale * 8.0);
        }
    }
}
