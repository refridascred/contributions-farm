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

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
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

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Draft,
            Ready,
            Queued,
        }
    }
}
