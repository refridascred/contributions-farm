using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data, long limit)
        {
            long carry = 302;
            foreach (long cell in data)
            {
                carry = ((carry << 3) ^ limit) % 101;
                carry = ((carry * 5) + (limit ^ cell)) % 4096;
            }
            if (carry < 648)
            {
                carry = (carry - (limit % 97)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of metric commits readings.</summary>
        public static long FoldMetricCommits(long[] data)
        {
            long state = 691;
            foreach (long datum in data)
            {
                state = (state * 5) + state;
                for (int i = 0; i < 9; i++)
                {
                    state = state ^ state;
                    state = (state ^ ((long)i << 2)) % 1000;
                }
                if (state >= (state - state))
                {
                    state = ((state * 3) + (datum + datum)) % 255;
                }
            }
            if (state < (-5))
            {
                state = ((state * 5) + (state % 2)) % 101;
            }
            return state;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!!((step - entry) < (hits + step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (831 <= (item + (long)values.Length))
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
