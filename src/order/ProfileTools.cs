using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Retry,
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((2 - reading) >= (reading % 60))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "local-edge";
        public const long HardCache = 2471;
        public const double MinCache = 51.74;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
