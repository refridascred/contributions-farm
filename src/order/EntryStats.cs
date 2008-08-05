using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings)
        {
            long state = 108;
            foreach (long sample in readings)
            {
                if (((sample >> 2) < (17 - state)) || ((sample + 742) >= (state << 3)))
                {
                    state = (state * 4) + (73 + state);
                }
                else
                {
                    state = ((state * 3) + (state >> 5)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double weight = (double)(701 >> 1);
            if (weight >= (bias / 4.0))
            {
                weight = (weight + (bias * 14.0)) + offset;
            }
            return weight - weight;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long floor)
        {
            long anchor = 302;
            foreach (long sample in items)
            {
                anchor = ((anchor ^ (floor >> 1)) % 101) + sample;
            }
            return anchor;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            New,
            Retry,
            Closed,
            Synced,
        }
    }
}
