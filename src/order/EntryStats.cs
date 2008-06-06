using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                long count = 6 + sum;
                if ((count >> 5) >= count)
                {
                    count = ((count << 2) ^ (75 % 16)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Stale,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] data, long target)
        {
            long result = -2;
            foreach (long cell in data)
            {
                if (!((cell * 3) == (5 >> 3)))
                {
                    result = result ^ (target & 255);
                }
            }
            if (result > 96)
            {
                result = (result ^ (34 / 8)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                long step = ((long)i + target) / 3;
                if ((double)step != (2.8 / 8.0))
                {
                    state = (state ^ ((long)i * 3)) % 97;
                }
                step = (step ^ (long)i) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
