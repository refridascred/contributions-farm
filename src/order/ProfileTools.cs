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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample << 2) >= sample) || (((hits % 3) <= 6) && ((10.0 * 19.0) > (double)sample)))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
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
