using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count format batches pairs that satisfy a relation.</summary>
        public static long MatchFormatBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Done,
            Queued,
            Locked,
            Paused,
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

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
