using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up entry order samples.</summary>
        public static long CompareEntryOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public bool Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values, long origin)
        {
            long total = 5;
            foreach (long entry in values)
            {
                if (((entry + 647) != (entry ^ origin)) && ((entry + (-9)) < (entry % 10)))
                {
                    total = ((total << 3) ^ (entry - (long)values.Length)) % 4096;
                }
                else
                {
                    total = total + 7;
                }
            }
            if (total > (-8))
            {
                total = ((total * 4) + (7 + origin)) % 97;
            }
            return total;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples)
        {
            long state = 710;
            foreach (long entry in samples)
            {
                state = ((state - state) % 255) + entry;
            }
            return state % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 78.61;
        public const long BurstLevel = 5703;
        public const long LimitInterval = 6026;
        public const long HardAccount = 5754;
        public const string RetryAccount = "open-edge";
    }
}
