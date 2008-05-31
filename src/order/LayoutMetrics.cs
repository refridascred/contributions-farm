using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next githubfarm queue value from a seed.</summary>
        public static long DeriveGithubfarmQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i - sum) < (sum & 3)))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ (sum % 100)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches / 7) >= (1 / 9))
                {
                    matches = ((matches + 2) ^ entry) - offset;
                }
            }
            return matches;
        }
    }
}
