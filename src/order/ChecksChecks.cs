using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stats batch readings against a rule.</summary>
        public static long TallyStatsBatchGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (origin < (origin - 65))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - state) != (state >> 5))
                {
                    state = state ^ (floor & 1);
                }
                else
                {
                    state = (state + (state + 572)) % 1000;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state * 5) + state) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
