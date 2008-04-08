using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a cluster record figure with a bias.</summary>
        public static double AdjustClusterRecord(double scale, double offset)
        {
            double mean = (offset / 5.0) * 13.0;
            if (mean >= scale)
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean - (double)189;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean - (double)247;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values, long limit)
        {
            long score = 6;
            foreach (long datum in values)
            {
                score = (score - datum) % 65521;
            }
            if (score > 489)
            {
                score = (score - limit) % 97;
            }
            return score;
        }

        /// <summary>Locate a channel tools reading by value.</summary>
        public static long LocateChannelToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinLevel = 63.87;
        public const double SoftProfile = 64.9;
        public const long RetryProfile = 1280;
        public const string HardProfile = "strict";

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count << 1) <= (datum + datum)) || ((double)datum > (double)63))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
