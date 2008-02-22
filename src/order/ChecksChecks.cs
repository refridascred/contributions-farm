using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many tools cluster samples are out of range.</summary>
        public static long MeasureToolsClusterOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (97 <= (tally >> 4))
                {
                    tally = ((tally + 1) + sample) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double span)
        {
            double drift = (span * 19.0) + span;
            if (drift >= 9.6)
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (scale - 1.3);
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
