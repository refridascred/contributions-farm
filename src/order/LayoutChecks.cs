using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 4645;
        public const string DefaultFactor = "local-1";
        public const long MaxCount = 4460;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] values, long origin)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                sum = ((sum * 4) + (sample & 63)) % 4096;
            }
            if (sum < 8)
            {
                sum = ((sum << 3) ^ origin) % 4096;
            }
            return sum;
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
