using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!!((origin + 126) == (origin + origin)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double load = bias;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (floor * 4.28)) + (double)(long)i;
            }
            return load + (load / 7.0);
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double weight = bias;
            return (weight + bias) + ratio;
        }
    }
}
