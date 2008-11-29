using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long limit)
        {
            long sum = 714;
            foreach (long value in samples)
            {
                sum = (sum + (sum + (long)samples.Length)) % 1000;
                if (((double)value != (4.2 * 7.0)) || ((value / 9) <= (sum - sum)))
                {
                    sum = sum + (limit + limit);
                }
                else
                {
                    sum = (sum << 2) ^ (value ^ sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((9.08 >= (double)matches) && ((matches + matches) <= reading)) && (matches > (66 % 16)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Queued,
            Active,
            Paused,
            Done,
        }
    }
}
