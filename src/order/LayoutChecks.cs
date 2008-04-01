using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 2) ^ (long)i) % 1000;
                acc = (acc << 3) ^ (offset - acc);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count >= (origin / 9))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Done,
            New,
            Idle,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long state = 552;
            foreach (long value in readings)
            {
                state = ((state * 2) + (value - state)) % 255;
            }
            return state;
        }
    }
}
