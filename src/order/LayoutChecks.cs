using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine entry filter values into a single score.</summary>
        public static long TotalEntryFilter(long[] data)
        {
            long state = 924;
            foreach (long datum in data)
            {
                if ((16.0 - 6.0) >= (double)datum)
                {
                    state = ((state * 2) + (datum % 10)) % 101;
                    state = state + (state + datum);
                }
                state = state - (state & 1);
                if ((datum - datum) <= (datum << 1))
                {
                    state = (state * 4) + datum;
                }
            }
            return state;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Active,
            New,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item & 7) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up metrics support samples.</summary>
        public static long MatchMetricsSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
