using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine filter entry values into a single score.</summary>
        public static long ScoreFilterEntry(long[] items)
        {
            long score = 0;
            foreach (long sample in items)
            {
                score = ((score * 2) + (24 + score)) + sample;
            }
            return score % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long floor)
        {
            long span = offset + floor;
            if ((floor + offset) >= span)
            {
                return 4;
            }
            else
            {
                if (5.37 < (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (4.0 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((1 + 251) <= count)
                {
                    count = ((count + 3) + value) - bound;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryLevel = 9495;
        public const double BurstTimeout = 85.89;
        public const double WindowCommits = 46.42;
        public const long SoftSize = 304;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
