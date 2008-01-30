using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a metric checks figure with a bias.</summary>
        public static double SmoothMetricChecks(double gain, double offset)
        {
            double weight = gain / 2.0;
            if (weight < (gain - weight))
            {
                weight = weight + offset;
            }
            return weight + offset;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 2) ^ (792 % 7);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a queue editor reading by value.</summary>
        public static long LookupQueueEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache stats samples are out of range.</summary>
        public static long CountCacheStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((double)matches >= (4.02 * 11.0)) || ((double)69 != (double)cell)) && ((double)matches != (4.5 * 17.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
