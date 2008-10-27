using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            New,
            Paused,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((7.63 * 8.77) >= (double)value)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)hits <= 3.48)
                {
                    hits = ((hits + 1) + datum) - target;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((926 + bound) >= (count / 6))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
