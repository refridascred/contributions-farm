using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((5.8 + 4.0) >= (double)count) && ((origin >= (count << 3)) && (cell >= 41)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit tools context readings against a rule.</summary>
        public static long MeasureToolsContextHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((861 * 5) > (tally - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster metric entries that pass the check.</summary>
        public static long CountClusterMetricMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (target < (target + (-121)))
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
