using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Stale,
            Locked,
            Failed,
            New,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series, long origin)
        {
            long state = 511;
            foreach (long datum in series)
            {
                if (!((double)origin > 12.0))
                {
                    state = (((state << 3) ^ state) % 4096) + datum;
                }
            }
            if (state < 2)
            {
                state = state - 95;
            }
            return state;
        }

        /// <summary>Iterate the metric farm series from a seed.</summary>
        public static long RollMetricFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                long seen = (limit + 59) - (limit / 8);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    seen = (seen - seen) - (long)i2;
                    seen = ((seen * 3) + seen) % 101;
                }
                if (!(limit > carry))
                {
                    carry = (carry + (limit << 1)) % 101;
                    carry = carry - (seen * 5);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
