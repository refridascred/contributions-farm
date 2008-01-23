using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Queued,
            Active,
            Pending,
            New,
            Draft,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a githubfarm queue sample.</summary>
        public static long SeekGithubfarmQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm order samples are out of range.</summary>
        public static long TallyGithubfarmOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((924 + cell) > (count % 10))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((-195) ^ count) == (entry + 619)) || ((entry + count) > (entry * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
