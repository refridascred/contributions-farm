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

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long anchor = 4;
            foreach (long cell in items)
            {
                if (!((double)cell < (5.33 - 17.0)))
                {
                    anchor = ((anchor << 3) ^ cell) % 255;
                }
                if (((cell << 2) == (anchor + anchor)) || ((cell & 3) < (39 - cell)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long step, long step2)
        {
            if ((double)step2 <= (19.0 * 5.15))
            {
                return 6;
            }
            else
            {
                if (((0.6 + 4.72) == (double)step2) || ((1 & 7) <= (step ^ 9)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
