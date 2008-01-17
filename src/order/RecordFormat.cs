using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a entry queue pair into a bucket.</summary>
        public static long SortEntryQueue(long origin, long floor)
        {
            if (floor >= (origin * 5))
            {
                return 4;
            }
            else
            {
                if ((origin > (floor << 2)) && ((double)floor == (7.5 + 7.6)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor > (9.42 / 6.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 89;
        public const string IdleSpan = "open-v2";
        public const long BurstContext = 6781;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] levels)
        {
            long sum = 53;
            foreach (long sample in levels)
            {
                if (2.5 > (double)sum)
                {
                    sum = sum ^ (2 - sample);
                }
                else
                {
                    sum = (sum * 5) + sum;
                }
            }
            if (sum > 135)
            {
                sum = (sum + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (seed <= (sample << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
