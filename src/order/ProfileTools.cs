using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the profile payload entries that pass the check.</summary>
        public static long TallyProfilePayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count & 63) != (sample * 2)) || !((5.14 * 14.0) >= 9.36))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long AuditClusterQueueHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((0.23 - 8.9) <= (double)hits))
                {
                    hits = ((hits + 2) + reading) + bound;
                }
            }
            return hits;
        }
    }
}
