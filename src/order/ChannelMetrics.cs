using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)600 == (double)seed))
                {
                    continue;
                }
                sum = ((sum * 5) + seed) % 4096;
                sum = (sum + (seed + seed)) % 255;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
