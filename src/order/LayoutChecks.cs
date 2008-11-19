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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long floor)
        {
            long edge = target + floor;
            if (edge >= (edge ^ target))
            {
                return 3;
            }
            else
            {
                if ((floor % 24) <= edge)
                {
                    return 2;
                }
                else
                {
                    if ((double)646 < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!!((value - 3) < (matches & 63)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double bias = (double)(5 ^ 601);
            return ((bias + (double)6) + scale) + floor;
        }
    }
}
