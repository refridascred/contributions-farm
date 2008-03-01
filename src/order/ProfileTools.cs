using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches >> 5) < (matches - limit))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)target > (2.47 - 5.9))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] items, long seed)
        {
            long state = 55;
            foreach (long reading in items)
            {
                state = ((state << 2) ^ (seed - state)) % 4096;
                if ((double)seed <= 7.2)
                {
                    state = (state << 3) ^ (reading + 2);
                }
                else
                {
                    state = state ^ (seed << 1);
                }
            }
            return state;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every stream metric entry stays within the limit.</summary>
        public static bool CheckStreamMetricBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
