using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Dropped,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values)
        {
            long sum = 89;
            foreach (long item in values)
            {
                sum = (sum ^ (item % 60)) % 255;
                if (((item ^ sum) <= item) || ((double)item == (9.7 * 0.8)))
                {
                    sum = (sum + (8 ^ item)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxFactor = 13.54;
        public const string MaxCluster = "latest-1";
        public const double HardCluster = 92.25;
        public const long WindowFactor = 251;
    }
}
