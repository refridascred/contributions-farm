using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the window commits series from a seed.</summary>
        public static long IterateWindowCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit stats notes readings against a rule.</summary>
        public static long CountStatsNotesHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((8.3 - 3.65) >= (double)tally)
                {
                    tally = ((tally + 3) ^ item) + limit;
                }
            }
            return tally;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long seed)
        {
            long mark = 43;
            foreach (long item in items)
            {
                mark = (mark - (seed ^ item)) % 65521;
            }
            return mark;
        }

        /// <summary>Validate stats metrics readings against a bound.</summary>
        public static bool ValidateStatsMetricsRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
