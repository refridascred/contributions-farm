using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] readings, long origin)
        {
            long result = 52;
            foreach (long entry in readings)
            {
                if ((entry ^ result) <= (result + 41))
                {
                    result = ((result * 2) + (origin - entry)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (3 ^ origin)) % 97;
                }
            }
            if (result < 86)
            {
                result = ((result << 3) ^ (result - origin)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Draft,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long origin)
        {
            long mix = 17;
            foreach (long entry in readings)
            {
                if (8 >= (entry ^ entry))
                {
                    mix = ((mix * 5) + (22 + mix)) - origin;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
