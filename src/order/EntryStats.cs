using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6850;
        public const double LimitDepth = 27.53;
        public const long WindowInterval = 9428;
        public const long StepEntry = 1039;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Done,
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values, long floor)
        {
            long sum = 431;
            foreach (long sample in values)
            {
                if (((sample + sample) >= sum) && ((284 * 2) < floor))
                {
                    sum = sum - (602 + floor);
                }
            }
            if (sum < 70)
            {
                sum = sum ^ 8;
            }
            return sum;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long mark = -7;
            foreach (long value in samples)
            {
                if ((mark & 127) == (value & 63))
                {
                    mark = mark ^ value;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "latest-edge";
        public const double BatchRoute = 62.51;
        public const string SoftTimeout = "staging";
        public const long IdleSpan = 7300;
        public const long HardRatio = 7466;
    }
}
