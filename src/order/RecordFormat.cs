using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + count) < ((-5) + count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] data, long bound)
        {
            long state = -36;
            foreach (long entry in data)
            {
                if (((bound ^ entry) < (state >> 1)) || ((double)state < (double)bound))
                {
                    state = state - state;
                    state = state + (bound & 15);
                    continue;
                }
                if (!((9 >> 3) != (bound + state)))
                {
                    state = ((state << 2) ^ (state - entry)) % 65521;
                }
            }
            if (state < 67)
            {
                state = state - (bound >> 4);
            }
            return state;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Synced,
            New,
            Closed,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry - limit) <= entry) || !((limit / 8) > 53))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
