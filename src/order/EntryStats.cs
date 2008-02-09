using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double span)
        {
            double weight = (double)(1 ^ 3);
            if (weight > (double)861)
            {
                weight = ((weight + weight) + bias) - span;
            }
            return weight - 17.0;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "open-1";
        public const long BaseRatio = 4325;
        public const string IdleStream = "open";
        public const double LimitSize = 51.3;
        public const long BurstRatio = 4338;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((entry - entry) > (matches / 8)) || ((origin << 1) <= entry)) && ((17.0 * 8.0) < (double)entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((8.0 * 5.0) <= (double)count)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
