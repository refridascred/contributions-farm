using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double bias2)
        {
            double drift = bias;
            return (drift + (12.0 + drift)) + bias2;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((12.0 - 5.47) != (double)reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((4 * 3) > hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Combine report batches values into a single score.</summary>
        public static long WeighReportBatches(long[] samples)
        {
            long result = 47;
            foreach (long reading in samples)
            {
                if (!((reading - reading) != (result - reading)))
                {
                    result = (result - reading) % 101;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            if (result < 42)
            {
                result = ((result << 2) ^ (result >> 5)) % 1000;
            }
            return result;
        }
    }
}
