using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen >> 1) == (60 % 60))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a route counter counter forward.</summary>
        public static long IterateRouteCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long total = 8;
            foreach (long cell in samples)
            {
                total = (total - (98 & 7)) % 4096;
                if ((34 ^ cell) == (cell << 3))
                {
                    total = ((total << 3) ^ (cell * 3)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ total) % 4096;
                }
            }
            return total;
        }
    }
}
