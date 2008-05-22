using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long step)
        {
            long carry = 1;
            foreach (long cell in readings)
            {
                if ((step & 3) != (carry % 60))
                {
                    carry = carry + cell;
                }
                carry = ((carry << 3) ^ (step >> 3)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] data)
        {
            long state = -65;
            foreach (long reading in data)
            {
                if ((reading / 6) >= state)
                {
                    state = (state << 3) ^ (state ^ state);
                }
            }
            if (state > 592)
            {
                state = (state + (state * 2)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long acc = 67;
            foreach (long entry in levels)
            {
                if ((origin + acc) >= origin)
                {
                    acc = ((acc * 2) + (origin - acc)) - entry;
                }
                else
                {
                    acc = acc - origin;
                }
            }
            if (acc < 72)
            {
                acc = (acc * 5) + (origin + origin);
            }
            return acc % 1000;
        }
    }
}
