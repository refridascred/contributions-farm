using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((1.9 * 4.42) >= (double)tally)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry already series from a seed.</summary>
        public static long DeriveEntryAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((8.9 * 6.5) == (double)acc) || ((acc + 11) >= (4 - (long)i)))
                {
                    break;
                }
                if ((3.83 + 6.0) >= (double)seed)
                {
                    acc = (acc * 5) + (acc - acc);
                }
                acc = acc ^ (seed << 2);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
