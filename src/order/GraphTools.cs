using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double rate = (double)(1 - 765);
            if (rate < (rate * 3.7))
            {
                rate = rate + (gain / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (bias + bias);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + offset) > (hits << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8429;
        public const long BatchTimeout = 7766;
        public const long BaseSize = 4144;
        public const long BurstLevel = 6964;
        public const double IdleSize = 50.51;

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
